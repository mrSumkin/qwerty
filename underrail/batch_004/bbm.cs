using System;
using System.Runtime.Serialization;
using Ouroboros.Common;
using Ouroboros.Core.Logging;

// Token: 0x0200015D RID: 349
[eiz("MPA")]
[Serializable]
public class bbm : esc, ISerializable
{
	// Token: 0x060008BE RID: 2238 RVA: 0x00024B50 File Offset: 0x00022D50
	protected bbm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetString("MPA:TPP");
		this.a = A_0.GetString("MPA:SPP");
		this.c = (A_0.GetValue("MPA:FN", typeof(IFunction<object, object>)) as IFunction<object, object>);
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x00024BA8 File Offset: 0x00022DA8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPA:TPP", this.b);
		info.AddValue("MPA:SPP", this.a);
		info.AddValue("MPA:FN", this.c);
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x00024BF0 File Offset: 0x00022DF0
	public IFunction<object, object> c()
	{
		return this.c;
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x00024BF8 File Offset: 0x00022DF8
	public void a(IFunction<object, object> A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00024C04 File Offset: 0x00022E04
	public string a()
	{
		return this.b;
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00024C0C File Offset: 0x00022E0C
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x00024C18 File Offset: 0x00022E18
	public string b()
	{
		return this.a;
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00024C20 File Offset: 0x00022E20
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00024C2C File Offset: 0x00022E2C
	public bbm()
	{
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00024C38 File Offset: 0x00022E38
	public override int d5(bq8 A_0, bq8 A_1)
	{
		int result;
		try
		{
			czh.a(this.a, "SourcePropertyPath");
			czh.a(this.b, "TargetPropertyPath");
			object obj = d8z.a(A_0, A_1, this.a);
			if (this.c != null)
			{
				obj = this.c.a(obj);
			}
			d8z.a(A_0, A_1, this.b, obj);
			result = 1;
		}
		catch (Exception ex)
		{
			string[] array = new string[8];
			array[0] = "Error trying to map properties (";
			array[1] = this.a;
			array[2] = " - > ";
			array[3] = this.b;
			array[4] = ", function: ";
			int num = 5;
			IFunction<object, object> function = this.c;
			array[num] = ((function != null) ? function.ToString() : null);
			array[6] = "). Exception: ";
			array[7] = ex.ToString();
			string str = string.Concat(array);
			if (bbm.d != null && bbm.d.n8() && bbm.d.n9(LogSeverity.Error, 115))
			{
				bbm.d.n7(LogSeverity.Error, 115, "[Dialog Manager] " + str);
			}
			result = 0;
		}
		return result;
	}

	// Token: 0x040005C1 RID: 1473
	private string a;

	// Token: 0x040005C2 RID: 1474
	private string b;

	// Token: 0x040005C3 RID: 1475
	private IFunction<object, object> c;

	// Token: 0x040005C4 RID: 1476
	private static cvq d = dr3.e();
}
