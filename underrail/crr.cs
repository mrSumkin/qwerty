using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020011D2 RID: 4562
[eiz("PCVHC")]
[Serializable]
public sealed class crr : c1i
{
	// Token: 0x060061E2 RID: 25058 RVA: 0x002A7734 File Offset: 0x002A5934
	private crr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("PCVHC:P");
	}

	// Token: 0x060061E3 RID: 25059 RVA: 0x002A7750 File Offset: 0x002A5950
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PCVHC:P", this.a);
	}

	// Token: 0x060061E4 RID: 25060 RVA: 0x002A776C File Offset: 0x002A596C
	public string a()
	{
		return this.a;
	}

	// Token: 0x060061E5 RID: 25061 RVA: 0x002A7774 File Offset: 0x002A5974
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060061E6 RID: 25062 RVA: 0x002A7780 File Offset: 0x002A5980
	public crr()
	{
	}

	// Token: 0x060061E7 RID: 25063 RVA: 0x002A7788 File Offset: 0x002A5988
	public crr(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060061E8 RID: 25064 RVA: 0x002A779C File Offset: 0x002A599C
	public override bcx qy()
	{
		if (!string.IsNullOrWhiteSpace(this.a))
		{
			string text = Path.Combine(bpo.GetServiceOrThrow<d67>().lf(), Path.Combine(d5x.ak, this.a + "." + bcx.a));
			if (File.Exists(text))
			{
				return bcx.a(text);
			}
		}
		return null;
	}

	// Token: 0x060061E9 RID: 25065 RVA: 0x002A77FC File Offset: 0x002A59FC
	public override c1i qz()
	{
		return new crr(this.a);
	}

	// Token: 0x04002990 RID: 10640
	private string a;
}
