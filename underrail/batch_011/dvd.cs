using System;
using System.Runtime.Serialization;

// Token: 0x02000FDC RID: 4060
[eiz("PVHA")]
[Serializable]
public sealed class dvd : esc
{
	// Token: 0x06005393 RID: 21395 RVA: 0x00250E44 File Offset: 0x0024F044
	private dvd(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("PVHA:C");
		this.b = A_0.GetInt32("PVHA:D");
	}

	// Token: 0x06005394 RID: 21396 RVA: 0x00250E70 File Offset: 0x0024F070
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PVHA:C", this.a);
		info.AddValue("PVHA:D", this.b);
	}

	// Token: 0x06005395 RID: 21397 RVA: 0x00250E9C File Offset: 0x0024F09C
	public string b()
	{
		return this.a;
	}

	// Token: 0x06005396 RID: 21398 RVA: 0x00250EA4 File Offset: 0x0024F0A4
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005397 RID: 21399 RVA: 0x00250EB0 File Offset: 0x0024F0B0
	public int a()
	{
		return this.b;
	}

	// Token: 0x06005398 RID: 21400 RVA: 0x00250EB8 File Offset: 0x0024F0B8
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005399 RID: 21401 RVA: 0x00250EC4 File Offset: 0x0024F0C4
	public dvd()
	{
	}

	// Token: 0x0600539A RID: 21402 RVA: 0x00250ED0 File Offset: 0x0024F0D0
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			string name = aya.a(this.a);
			dic classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<dic>(name);
			if (classPropertyValue != null)
			{
				int a_;
				if (this.b == 0)
				{
					a_ = classPropertyValue.BuyPriceWithDiscount0;
				}
				else if (this.b == 1)
				{
					a_ = classPropertyValue.BuyPriceWithDiscount1;
				}
				else if (this.b == 2)
				{
					a_ = classPropertyValue.BuyPriceWithDiscount2;
				}
				else
				{
					a_ = classPropertyValue.BuyPriceWithDiscount3;
				}
				c5x c5x = classPropertyValue.b().ao() as c5x;
				if (c5x != null)
				{
					wv wv = c5x.GetAspect<bim>() as wv;
					if (wv != null && wv.g() != null)
					{
						wv.g().l().Clear();
						serviceOrThrow.aqu().v().a("currency.sc", a_, false);
					}
					c3g aspect = c5x.GetAspect<c3g>();
					if (aspect != null)
					{
						aspect.d().Clear();
					}
				}
			}
		}
		return 0;
	}

	// Token: 0x04002216 RID: 8726
	private string a;

	// Token: 0x04002217 RID: 8727
	private int b;
}
