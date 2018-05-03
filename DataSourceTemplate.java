package {0};

import java.util.ArrayList;
import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.DatabaseUtils;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;

public class DataSource{1} {{
	
	private SQLiteDatabase database;
	private MySqliteHelper dbHelper;
	  
	public static final String TABLE_Name = "{1}";
	{2}
	  
	private String[] allColumns = {{ {3} }};
	  
	public DataSource{1}(Context context) {{
	    dbHelper = new MySqliteHelper(context);
	}}

	public void open() throws SQLException {{
	    database = dbHelper.getWritableDatabase();
	}}

	public void close() {{
	    dbHelper.close();
	}}
	  
	public long Insert({1} p) {{
		ContentValues values = new ContentValues();		   
		{4}
		long insertId = database.insert(TABLE_Name, null, values);		    
		return insertId;
	}}
	
	public void Update({1} p) {{
	    ContentValues values = new ContentValues();
		{4}
		database.update(TABLE_Name, values , {5}+"="+p.get{8} , null);
	}}
	
	public void DeleteAll()
	{{
		database.delete(TABLE_Name, null, null);		
	}}
	
	public boolean DeleteById({6} id)
	{{
		return database.delete(TABLE_Name, {5} +"="+id  , null) > 0;		
	}}
	
	public long GetCount()
	{{
		return DatabaseUtils.queryNumEntries(database, TABLE_Name);
	}}
	
	public  {1} GetById({6} id) {{
		 
		    Cursor cursor = database.query(TABLE_Name,
		        allColumns, {5}+"="+id, null, null, null, null);
		    {1} obj = new {1}();
		    cursor.moveToFirst();
		    if (!cursor.isAfterLast()) {{
		    	fillObjFromCursor(cursor, obj);
		    }}
		    // Make sure to close the cursor
		    cursor.close();
		    return  obj ;
	}}
	
	
	public  ArrayList<{1}>  getAlls() {{
		  ArrayList<{1}> list = new ArrayList<{1}>();

		    Cursor cursor = database.query(TABLE_Name,
		        allColumns, null, null, null, null, null);

		    cursor.moveToFirst();
		    while (!cursor.isAfterLast()) {{
		    	{1} obj = new {1}();
		    	fillObjFromCursor(cursor, obj);
		    	list.add(obj);
		        cursor.moveToNext();
		    }}
		    // Make sure to close the cursor
		    cursor.close();
		    return  list ;
	}}

	private void fillObjFromCursor(Cursor cursor , {1} obj)
	{{
		{7}
	}}
}}
