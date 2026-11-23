using System;
using System.Runtime.Serialization;

// Token: 0x020000CE RID: 206
public sealed class dds : SerializationBinder
{
	// Token: 0x06000486 RID: 1158 RVA: 0x00014840 File Offset: 0x00012A40
	public static dds a()
	{
		return dds.b;
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00014848 File Offset: 0x00012A48
	public override Type BindToType(string assemblyName, string typeName)
	{
		if (dds.a != null)
		{
			return dds.a.av3(typeName, assemblyName, true);
		}
		throw new InvalidOperationException("Assembly resolver not set!");
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x0001486C File Offset: 0x00012A6C
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName)
	{
		if (dds.a != null)
		{
			dds.a.av5(serializedType, out typeName, out assemblyName, true);
			return;
		}
		throw new InvalidOperationException("Assembly resolver not set!");
	}

	// Token: 0x04000448 RID: 1096
	public static ei2 a;

	// Token: 0x04000449 RID: 1097
	private static dds b = new dds();
}
