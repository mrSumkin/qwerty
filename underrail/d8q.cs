using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02000FC5 RID: 4037
[eiz("PHCC")]
[Serializable]
public sealed class d8q : dnh
{
	// Token: 0x060052EE RID: 21230 RVA: 0x0024F3B4 File Offset: 0x0024D5B4
	private d8q(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PHCC:I");
	}

	// Token: 0x060052EF RID: 21231 RVA: 0x0024F3D0 File Offset: 0x0024D5D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PHCC:I", this.a);
	}

	// Token: 0x060052F0 RID: 21232 RVA: 0x0024F3EC File Offset: 0x0024D5EC
	public bool a()
	{
		return this.a;
	}

	// Token: 0x060052F1 RID: 21233 RVA: 0x0024F3F4 File Offset: 0x0024D5F4
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060052F2 RID: 21234 RVA: 0x0024F400 File Offset: 0x0024D600
	public d8q()
	{
	}

	// Token: 0x060052F3 RID: 21235 RVA: 0x0024F408 File Offset: 0x0024D608
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null && service.aqu().v() != null)
		{
			bool flag = false;
			foreach (coh coh in Enumerable.Union<coh>(service.aqu().v().Bag.z2(), service.aqu().v().Gear.i()))
			{
				if (coh != null && !string.IsNullOrEmpty(coh.Definition.a5()) && coh.Definition.a5().IndexOf("crowbar", StringComparison.OrdinalIgnoreCase) != -1)
				{
					flag = true;
					break;
				}
			}
			return flag ^ this.a;
		}
		return false;
	}

	// Token: 0x040021ED RID: 8685
	private bool a;
}
