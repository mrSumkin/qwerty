using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020000DF RID: 223
public class cxm : ISerializationSurrogate
{
	// Token: 0x060004E6 RID: 1254 RVA: 0x000165A8 File Offset: 0x000147A8
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
		info.AddValue("packedValue", ((Color)obj).PackedValue);
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x000165D0 File Offset: 0x000147D0
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		uint @uint = info.GetUInt32("packedValue");
		return new Color
		{
			PackedValue = @uint
		};
	}

	// Token: 0x0400046F RID: 1135
	public static cxm a = new cxm();
}
