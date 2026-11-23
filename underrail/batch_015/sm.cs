using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020000E1 RID: 225
public class sm : ISerializationSurrogate
{
	// Token: 0x060004EE RID: 1262 RVA: 0x000166B0 File Offset: 0x000148B0
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
		Vector2 vector = (Vector2)obj;
		info.AddValue("X", vector.X);
		info.AddValue("Y", vector.Y);
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x000166E8 File Offset: 0x000148E8
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		float single = info.GetSingle("X");
		float single2 = info.GetSingle("Y");
		return new Vector2(single, single2);
	}

	// Token: 0x04000471 RID: 1137
	public static sm a = new sm();
}
