using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000FC9 RID: 4041
[eiz("PHECTPVC")]
[Serializable]
public sealed class c8w : dnh
{
	// Token: 0x06005310 RID: 21264 RVA: 0x0024F958 File Offset: 0x0024DB58
	private c8w(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PHECTPVC:I");
		this.b = A_0.GetString("PHECTPVC:C");
		this.c = A_0.GetInt32("PHECTPVC:D");
	}

	// Token: 0x06005311 RID: 21265 RVA: 0x0024F9A0 File Offset: 0x0024DBA0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PHECTPVC:I", this.a);
		info.AddValue("PHECTPVC:C", this.b);
		info.AddValue("PHECTPVC:D", this.c);
	}

	// Token: 0x06005312 RID: 21266 RVA: 0x0024F9E8 File Offset: 0x0024DBE8
	public bool c()
	{
		return this.a;
	}

	// Token: 0x06005313 RID: 21267 RVA: 0x0024F9F0 File Offset: 0x0024DBF0
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005314 RID: 21268 RVA: 0x0024F9FC File Offset: 0x0024DBFC
	public string b()
	{
		return this.b;
	}

	// Token: 0x06005315 RID: 21269 RVA: 0x0024FA04 File Offset: 0x0024DC04
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005316 RID: 21270 RVA: 0x0024FA10 File Offset: 0x0024DC10
	public int a()
	{
		return this.c;
	}

	// Token: 0x06005317 RID: 21271 RVA: 0x0024FA18 File Offset: 0x0024DC18
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005318 RID: 21272 RVA: 0x0024FA24 File Offset: 0x0024DC24
	public c8w()
	{
	}

	// Token: 0x06005319 RID: 21273 RVA: 0x0024FA30 File Offset: 0x0024DC30
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk service = bpo.GetService<cnk>();
		if (service != null && service.aqu() != null && service.aqu().v() != null)
		{
			bool flag = false;
			string name = aya.a(this.b);
			dic classPropertyValue = service.aqu().r().GetClassPropertyValue<dic>(name);
			if (classPropertyValue != null)
			{
				int num;
				if (this.c == 0)
				{
					num = classPropertyValue.BuyPriceWithDiscount0;
				}
				else if (this.c == 1)
				{
					num = classPropertyValue.BuyPriceWithDiscount1;
				}
				else if (this.c == 2)
				{
					num = classPropertyValue.BuyPriceWithDiscount2;
				}
				else
				{
					num = classPropertyValue.BuyPriceWithDiscount3;
				}
				flag = (Enumerable.Sum<d5o>(service.aqu().v().b("currency.sc", num, false), new Func<d5o, int>(c8w.a.a.a)) >= num);
			}
			return flag ^ this.a;
		}
		return false;
	}

	// Token: 0x040021F6 RID: 8694
	private bool a;

	// Token: 0x040021F7 RID: 8695
	private string b;

	// Token: 0x040021F8 RID: 8696
	private int c;

	// Token: 0x02000FCA RID: 4042
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600531C RID: 21276 RVA: 0x0024FB44 File Offset: 0x0024DD44
		internal int a(d5o A_0)
		{
			return A_0.StackPortion;
		}

		// Token: 0x040021F9 RID: 8697
		public static readonly c8w.a a = new c8w.a();

		// Token: 0x040021FA RID: 8698
		public static Func<d5o, int> b;
	}
}
