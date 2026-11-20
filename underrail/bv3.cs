using System;
using System.Reflection;
using System.Runtime.Serialization;

// Token: 0x02000718 RID: 1816
[eiz("IGI")]
[Serializable]
public sealed class bv3 : ISerializable
{
	// Token: 0x06002F23 RID: 12067 RVA: 0x0011DE44 File Offset: 0x0011C044
	private bv3(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("IGI:N");
			this.b = A_0.GetString("IGI:FN");
			if (ell.a() >= 3)
			{
				this.c = di7.a("IGI:IT", A_0);
				return;
			}
			this.c = (Type)A_0.GetValue("IGI:IT", typeof(Type));
			return;
		}
		else
		{
			if (base.GetType() == typeof(bv3))
			{
				this.a = A_0.GetString("_Name");
				this.b = A_0.GetString("_FriendlyName");
				this.c = (Type)A_0.GetValue("_ImplementationType", typeof(Type));
				return;
			}
			this.a = A_0.GetString("ItemGeneratorInfo+_Name");
			this.b = A_0.GetString("ItemGeneratorInfo+_FriendlyName");
			this.c = (Type)A_0.GetValue("ItemGeneratorInfo+_ImplementationType", typeof(Type));
			return;
		}
	}

	// Token: 0x06002F24 RID: 12068 RVA: 0x0011DF60 File Offset: 0x0011C160
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("IGI:N", this.a);
		info.AddValue("IGI:FN", this.b);
		di7.a("IGI:IT", this.c, info);
	}

	// Token: 0x06002F25 RID: 12069 RVA: 0x0011DF98 File Offset: 0x0011C198
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002F26 RID: 12070 RVA: 0x0011DFA0 File Offset: 0x0011C1A0
	public string a()
	{
		return this.b;
	}

	// Token: 0x06002F27 RID: 12071 RVA: 0x0011DFA8 File Offset: 0x0011C1A8
	public Type b()
	{
		return this.c;
	}

	// Token: 0x06002F28 RID: 12072 RVA: 0x0011DFB0 File Offset: 0x0011C1B0
	public bv3(Type A_0)
	{
		czh.a(A_0, "generatorType");
		this.c = A_0;
		this.a = A_0.Name;
		this.b = bv3.a(this.c);
	}

	// Token: 0x06002F29 RID: 12073 RVA: 0x0011DFE8 File Offset: 0x0011C1E8
	public static string a(Type A_0)
	{
		if (A_0 != null)
		{
			FieldInfo field = A_0.GetField("Name", BindingFlags.Static | BindingFlags.NonPublic);
			if (field != null && field.FieldType == typeof(string))
			{
				try
				{
					return field.GetValue(null) as string;
				}
				catch
				{
				}
			}
			return A_0.Name;
		}
		return null;
	}

	// Token: 0x06002F2A RID: 12074 RVA: 0x0011E068 File Offset: 0x0011C268
	public override string ToString()
	{
		return this.b;
	}

	// Token: 0x04001A1C RID: 6684
	private string a;

	// Token: 0x04001A1D RID: 6685
	private string b;

	// Token: 0x04001A1E RID: 6686
	private Type c;
}
