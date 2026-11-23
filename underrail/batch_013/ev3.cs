using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

// Token: 0x02000084 RID: 132
public class ev3 : SerializationBinder
{
	// Token: 0x06000309 RID: 777 RVA: 0x0000DD44 File Offset: 0x0000BF44
	public ev3()
	{
		this.a(1);
	}

	// Token: 0x0600030A RID: 778 RVA: 0x0000DD54 File Offset: 0x0000BF54
	public override Type BindToType(string assemblyName, string typeName)
	{
		if (assemblyName == null)
		{
			throw new ArgumentNullException("assemblyName");
		}
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		string typeName2 = string.Format("{0}, {1}", typeName, assemblyName);
		FormatterAssemblyStyle formatterAssemblyStyle = this.a();
		if (formatterAssemblyStyle == null)
		{
			return Type.GetType(typeName2, new Func<AssemblyName, Assembly>(ev3.a.a.a), null, true);
		}
		if (formatterAssemblyStyle == 1)
		{
			return Type.GetType(typeName2, true);
		}
		throw new SerializationException(string.Format("Unsupported AssemblyStyle '{0}' defined in DefaultSerializationBinder.", this.a()));
	}

	// Token: 0x0600030B RID: 779 RVA: 0x0000DDF4 File Offset: 0x0000BFF4
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName)
	{
		if (serializedType == null)
		{
			throw new ArgumentNullException("serializedType");
		}
		assemblyName = serializedType.Assembly.FullName;
		FormatterAssemblyStyle formatterAssemblyStyle = this.a();
		if (formatterAssemblyStyle != null)
		{
			if (formatterAssemblyStyle != 1)
			{
				throw new SerializationException("Unsupported AssemblyStyle.");
			}
			assemblyName = serializedType.Assembly.FullName;
		}
		else
		{
			assemblyName = serializedType.Assembly.GetName().Name;
		}
		typeName = serializedType.FullName;
	}

	// Token: 0x0600030C RID: 780 RVA: 0x0000DE78 File Offset: 0x0000C078
	[CompilerGenerated]
	public FormatterAssemblyStyle a()
	{
		return this.a;
	}

	// Token: 0x0600030D RID: 781 RVA: 0x0000DE80 File Offset: 0x0000C080
	[CompilerGenerated]
	public void a(FormatterAssemblyStyle A_0)
	{
		this.a = A_0;
	}

	// Token: 0x040003DC RID: 988
	[CompilerGenerated]
	private FormatterAssemblyStyle a;

	// Token: 0x02000085 RID: 133
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06000310 RID: 784 RVA: 0x0000DEA0 File Offset: 0x0000C0A0
		internal Assembly a(AssemblyName A_0)
		{
			return Assembly.LoadWithPartialName(A_0.Name);
		}

		// Token: 0x040003DD RID: 989
		public static readonly ev3.a a = new ev3.a();

		// Token: 0x040003DE RID: 990
		public static Func<AssemblyName, Assembly> b;
	}
}
