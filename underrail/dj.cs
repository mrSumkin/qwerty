using System;
using System.Reflection;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x0200015C RID: 348
[eiz("IMA")]
[Serializable]
public sealed class dj : esc, ISerializable
{
	// Token: 0x060008B4 RID: 2228 RVA: 0x00024844 File Offset: 0x00022A44
	private dj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("IMA:TOP");
			this.b = A_0.GetString("IMA:MN");
			return;
		}
		if (base.GetType() == typeof(dj))
		{
			this.a = A_0.GetString("_TargetObjectPath");
			this.b = A_0.GetString("_MethodName");
			return;
		}
		this.a = A_0.GetString("InvokeMethodAction+_TargetObjectPath");
		this.b = A_0.GetString("InvokeMethodAction+_MethodName");
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x000248E8 File Offset: 0x00022AE8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("IMA:TOP", this.a);
		info.AddValue("IMA:MN", this.b);
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x00024914 File Offset: 0x00022B14
	public string a()
	{
		return this.a;
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x0002491C File Offset: 0x00022B1C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00024928 File Offset: 0x00022B28
	public string b()
	{
		return this.b;
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00024930 File Offset: 0x00022B30
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x0002493C File Offset: 0x00022B3C
	public override int d5(bq8 A_0, bq8 A_1)
	{
		czh.a(this.b, "_MethodName");
		czh.a(this.a, "_TargetObjectPath");
		object obj = d8z.a(A_0, A_1, this.a());
		if (obj == null)
		{
			cvq cvq = dr3.e();
			string str = "Error executing InvokeMethodAction '" + base.Name + "'. Failed to retrieve target object.";
			if (cvq != null && cvq.n8() && cvq.n9(LogSeverity.Error, 115))
			{
				cvq.n7(LogSeverity.Error, 115, "[Dialog Manager] " + str);
			}
			return 0;
		}
		int result = 0;
		if (this.a(obj, new Type[]
		{
			typeof(bq8),
			typeof(bq8)
		}, new object[]
		{
			A_0,
			A_1
		}, out result))
		{
			return result;
		}
		if (this.a(obj, new Type[]
		{
			typeof(bq8)
		}, new object[]
		{
			A_0
		}, out result))
		{
			return result;
		}
		if (this.a(obj, Type.EmptyTypes, new object[0], out result))
		{
			return result;
		}
		throw new Exception(string.Format("Failed to locate suitable public instance method '{0}' in type '{1}'.", this.b, this.a));
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x00024A74 File Offset: 0x00022C74
	private bool a(object A_0, Type[] A_1, object[] A_2, out int A_3)
	{
		A_3 = 0;
		MethodInfo method = A_0.GetType().GetMethod(this.b, BindingFlags.Instance | BindingFlags.Public, null, A_1, null);
		if (method != null)
		{
			object obj = method.Invoke(A_0, A_2);
			if (obj is int)
			{
				A_3 = (int)obj;
			}
			return true;
		}
		return false;
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x00024AC8 File Offset: 0x00022CC8
	public dj()
	{
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x00024AD0 File Offset: 0x00022CD0
	public override bool h5(string A_0, bool A_1)
	{
		return base.h5(A_0, A_1) || (!string.IsNullOrEmpty(this.a) && this.a.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1) || (!string.IsNullOrEmpty(this.b) && this.b.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1);
	}

	// Token: 0x040005BF RID: 1471
	private string a;

	// Token: 0x040005C0 RID: 1472
	private string b;
}
