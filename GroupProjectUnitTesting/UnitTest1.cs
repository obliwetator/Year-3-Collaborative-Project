using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using GroupProject.Classes;
using GroupProject.Classes.Car;
using GroupProject.Classes.Salesman;
using GroupProject.Classes.SerialzationClasses;

namespace GroupProjectUnitTesting
{
  // When trying to come up with tests I realized that all the program functionality lies in the 
  // interactions within window forms which cannot be easily tested as such the primary
  // focus will be to check the integrity of the database to make sure the right data is splayed as intended
  [TestClass]
  public class AdminTests
  {
    [TestMethod]
    public void TestMethod1()
    {
    }

  }
  [TestClass]
  public class USerTests
  {
    // For some reason the Deserialization throws a strange error even though the same code is used
    [TestMethod]
    public void ReadJson()
    {
      // OpenFileDialog ofd = new OpenFileDialog()
      // {
      //   Filter = "JSON File (*.json)|*.json",
      //   Title = "Load your configuration",
      // };
      //
      // if (ofd.ShowDialog() != DialogResult.OK) return;

      // Open the text file using a stream reader.
      // Normally a pop up window asking for the file location would show up
      var sr = new StreamReader("../../../sample.json");
      // Read the stream as a string, then decode that string as our object
      var a = sr.ReadToEnd();
      var config = JsonSerializer.Deserialize<UserSaveLoadConfig>(a);
      
      Assert.AreEqual(config.car.Id, 1);
    }

  }
  [TestClass]
  public class SalesmanTests
  {
    private readonly ClsCar car = new ClsCar()
    {
      Id = 1,
      ModelId = 3,
      TypeId = 2,
      Year = 2000,
      Price = 999.99f,
      Model = "Civic",
      Type = "sport",
      CarConfigurationsChosen = new Dictionary<string, bool>()
      {
        {"1", true},
        {"3", true}
      }
    };

    private ulong _configId;
    [TestMethod]
    public void TestCar()
    {
      var a = ClsDatabase.GetCar(1);
      Assert.AreEqual(a.Id, 1);
      Assert.AreEqual(a.ModelId, 3);
      Assert.AreEqual(a.TypeId, 2);
      Assert.AreEqual(a.Year, 2000);
      Assert.AreEqual(a.Price, 999.99f);
    }
    [TestMethod]
    public void AddUserConfig()
    {
      _configId = ClsDatabase.AddUserCarConfiguration(car,1,"",0,true, true);
    }
    [TestMethod]
    public void SendConfigForReview()
    {
      var modsSelected = new HashSet<int>()
      {
        {1}, {3}
      };
      ClsDatabase.AddUserCarConfiguration(car, 1,"", 0, true, false);
    }
    [TestMethod]
    public void DeleteConfig()
    {
      ClsDatabase.AddUserCarConfiguration(car, 1,"", 0, true, false);
      
      ClsDatabase.DeleteUserConfiguration((int)_configId);
    }
    
    [TestMethod]
    public void CheckReviews()
    {
      var toBeReviewed = ClsDatabase.GetUsersConfigForReview();
      
      Assert.AreEqual(toBeReviewed[0].Id, 2);
    }
    [TestMethod]
    public void CheckMods()
    {
      var mods = ClsDatabase.GetModificationsAvailable();
      
      Assert.AreEqual(mods[1].Modification, "colour");
    }
  }
  [TestClass]
  public class DatabaseTests
  {
    [TestMethod]
    public void TestMethod1()
    {
    }

  }

}
