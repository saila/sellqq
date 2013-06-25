using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using GetQQ.Properties;

/// <summary>
/// TestDatebase 的摘要说明
/// </summary>
public static class BaseDao
{
    private static Settings s = Settings.Default;
    public static string mysqlStr = s.dbconn;
        
    /// <summary>
    /// 建立mysql数据库链接
    /// </summary>
    /// <returns></returns>
    public static MySqlConnection getMySqlCon()
    {
        //String mySqlCon = ConfigurationManager.ConnectionStrings["MySqlCon"].ConnectionString;
        MySqlConnection mysql = new MySqlConnection(mysqlStr);
        return mysql;
    }
    /// <summary>
    /// 建立执行命令语句对象
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="mysql"></param>
    /// <returns></returns>
    public static MySqlCommand getSqlCommand(String sql, MySqlConnection mysql)
    {
        MySqlCommand mySqlCommand = new MySqlCommand(sql, mysql);
        //  MySqlCommand mySqlCommand = new MySqlCommand(sql);
        // mySqlCommand.Connection = mysql;
        return mySqlCommand;
    }
    /// <summary>
    /// 查询并获得结果集并遍历
    /// </summary>
    /// <param name="mySqlCommand"></param>
    public static DataTable getResultset(MySqlCommand mySqlCommand, string[] cols)
    {
        DataTable dt = new DataTable();
        MySqlDataReader reader = mySqlCommand.ExecuteReader();
        try
        {
            int count = cols.Length;
            for (int i = 0; i < cols.Length;i++)
            {
                dt.Columns.Add(cols[i]);
            }
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    DataRow row = dt.NewRow();
                    for (int j = 0; j < cols.Length; j++)
                    {
                        row[cols[j]] = reader.GetString(j);
                    }
                    dt.Rows.Add(row);
                }
            }
        }
        catch (Exception e)
        {
            MessageBox.Show("数据查询失败!\n"+e.Message);
        }
        finally
        {
            reader.Close();
        }
        return dt;
    }

    /// <summary>
    /// 添加数据
    /// </summary>
    /// <param name="mySqlCommand"></param>
    public static void getInsert(MySqlCommand mySqlCommand)
    {
        try
        {
            mySqlCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            String message = ex.Message;
            MessageBox.Show("插入数据失败了！" + message);
        }

    }

    /// <summary>
    /// 修改数据
    /// </summary>
    /// <param name="mySqlCommand"></param>
    public static void getUpdate(MySqlCommand mySqlCommand)
    {
        try
        {
            mySqlCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            String message = ex.Message;
            MessageBox.Show("修改数据失败！" + message);
        }
    }
    /// <summary>
    /// 删除数据
    /// </summary>
    /// <param name="mySqlCommand"></param>
    public static void getDel(MySqlCommand mySqlCommand)
    {
        try
        {
            mySqlCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            String message = ex.Message;
            MessageBox.Show("删除数据失败！" + message);
        }
    }
}