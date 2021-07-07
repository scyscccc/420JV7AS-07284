using Mono.Data.Sqlite;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public static class Database
{
    private static IDbConnection connection;
    private static IDataReader reader;

    public static string DatabasePath => $"URI=file:{Application.dataPath}/Databases/Weapons.db";

    public static void Insert(Weapon weapon)
    {
        ExecuteCommand($"INSERT INTO Weapons VALUES ('{weapon.Name}', '{weapon.Cost}')");
        Close();
    }

    public static List<Weapon> GetAll()
    {
        var weapons = new List<Weapon>();

        reader = ExecuteCommand("SELECT * FROM Weapons");
        while (reader.Read())
        {
            weapons.Add(new Weapon(reader.GetString(0), reader.GetInt32(1)));
        }

        Close();
        return weapons;
    }

    public static IDataReader ExecuteCommand(string commandText)
    {
        connection = new SqliteConnection(DatabasePath);
        connection.Open();
        IDbCommand command = connection.CreateCommand();
        command.CommandText = commandText;
        return command.ExecuteReader();
    }

    private static void Close()
    {
        reader.Close();
        connection.Close();
    }
}
