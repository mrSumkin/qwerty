using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020000E2 RID: 226
public class ccx : ISerializationSurrogate
{
	// Token: 0x060004F2 RID: 1266 RVA: 0x00016730 File Offset: 0x00014930
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
		Point point = (Point)obj;
		info.AddValue("X", point.X);
		info.AddValue("Y", point.Y);
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00016768 File Offset: 0x00014968
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		int @int = info.GetInt32("X");
		int int2 = info.GetInt32("Y");
		return new Point(@int, int2);
	}

	// Token: 0x04000472 RID: 1138
	public static ccx a = new ccx();
}
