package {0};


import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

public class MySqliteHelper extends SQLiteOpenHelper {{
   
  private static final String DATABASE_NAME = "{2}";
  private static final int DATABASE_VERSION = 1;

  // Database creation sql statement
  {1}

  public MySqliteHelper(Context context) {{
    super(context, DATABASE_NAME, null, DATABASE_VERSION);
  }}

  @Override
  public void onCreate(SQLiteDatabase database) {{
    {3}
  }}

  @Override
  public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {{
    Log.w(MySqliteHelper.class.getName(),        "Upgrading database from version " + oldVersion + " to "+ newVersion + ", which will destroy all old data");
    {4}
    onCreate(db);
  }}

}} 