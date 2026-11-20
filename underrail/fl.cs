using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020000E0 RID: 224
public class fl : ISerializationSurrogate
{
	// Token: 0x060004EA RID: 1258 RVA: 0x00016618 File Offset: 0x00014818
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
		Vector3 vector = (Vector3)obj;
		info.AddValue("X", vector.X);
		info.AddValue("Y", vector.Y);
		info.AddValue("Z", vector.Z);
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00016660 File Offset: 0x00014860
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		float single = info.GetSingle("X");
		float single2 = info.GetSingle("Y");
		float single3 = info.GetSingle("Z");
		return new Vector3(single, single2, single3);
	}

	// Token: 0x04000470 RID: 1136
	public static fl a = new fl();
}
