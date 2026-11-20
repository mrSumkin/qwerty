using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020000E3 RID: 227
public class blz : ISerializationSurrogate
{
	// Token: 0x060004F6 RID: 1270 RVA: 0x000167B0 File Offset: 0x000149B0
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
	{
		Matrix matrix = (Matrix)obj;
		info.AddValue("M11", matrix.M11);
		info.AddValue("M12", matrix.M11);
		info.AddValue("M13", matrix.M11);
		info.AddValue("M14", matrix.M11);
		info.AddValue("M21", matrix.M11);
		info.AddValue("M22", matrix.M11);
		info.AddValue("M23", matrix.M11);
		info.AddValue("M24", matrix.M11);
		info.AddValue("M31", matrix.M11);
		info.AddValue("M32", matrix.M11);
		info.AddValue("M33", matrix.M11);
		info.AddValue("M34", matrix.M11);
		info.AddValue("M41", matrix.M11);
		info.AddValue("M42", matrix.M11);
		info.AddValue("M43", matrix.M11);
		info.AddValue("M44", matrix.M11);
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x000168D4 File Offset: 0x00014AD4
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		float single = info.GetSingle("M11");
		float single2 = info.GetSingle("M12");
		float single3 = info.GetSingle("M13");
		float single4 = info.GetSingle("M14");
		float single5 = info.GetSingle("M21");
		float single6 = info.GetSingle("M22");
		float single7 = info.GetSingle("M23");
		float single8 = info.GetSingle("M24");
		float single9 = info.GetSingle("M31");
		float single10 = info.GetSingle("M32");
		float single11 = info.GetSingle("M33");
		float single12 = info.GetSingle("M34");
		float single13 = info.GetSingle("M41");
		float single14 = info.GetSingle("M42");
		float single15 = info.GetSingle("M43");
		float single16 = info.GetSingle("M44");
		return new Matrix(single, single2, single3, single4, single5, single6, single7, single8, single9, single10, single11, single12, single13, single14, single15, single16);
	}

	// Token: 0x04000473 RID: 1139
	public static blz a = new blz();
}
