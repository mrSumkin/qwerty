using System;
using System.Runtime.Serialization;

// Token: 0x020000CF RID: 207
public class ed9 : SerializationBinder
{
	// Token: 0x0600048B RID: 1163 RVA: 0x000148A8 File Offset: 0x00012AA8
	public static ed9 a()
	{
		return ed9.a;
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x000148B0 File Offset: 0x00012AB0
	public override Type BindToType(string assemblyName, string typeName)
	{
		return Type.GetType(typeName + ", " + assemblyName);
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x000148C8 File Offset: 0x00012AC8
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName)
	{
		assemblyName = serializedType.Assembly.GetName().Name;
		typeName = serializedType.FullName;
	}

	// Token: 0x0400044A RID: 1098
	private static ed9 a = new ed9();
}
