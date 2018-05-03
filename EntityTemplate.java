package {0};

import android.os.Parcel;
import android.os.Parcelable;

public class {1} implements Parcelable {{
	{2}
	
	public {1}()
	{{		
	}}
	
	public {1}(Parcel in)
	{{		
		{3}
	}}
	
	{4}
	
	@Override
	public int describeContents() {{
		// TODO Auto-generated method stub
		return 0;
	}}

	@Override
	public void writeToParcel(Parcel out, int arg1) {{
		{5}
	}}		

	public static final Parcelable.Creator<{1}> CREATOR = new Creator<{1}>() {{
		
		@Override
		public {1}[] newArray(int size) {{
			// TODO Auto-generated method stub
			return new {1}[size];
		}}
		
		@Override
		public {1} createFromParcel(Parcel in) {{
			// TODO Auto-generated method stub
			return new {1}(in);
		}}
	}};
	
}}
