using System;
using System.Runtime.Serialization;

// Token: 0x020016C8 RID: 5832
[eiz("TJSKIA")]
[Serializable]
public sealed class dmt : a6k
{
	// Token: 0x06007F10 RID: 32528 RVA: 0x0035C3B0 File Offset: 0x0035A5B0
	private dmt(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F11 RID: 32529 RVA: 0x0035C3C0 File Offset: 0x0035A5C0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = this.fm() as c5x;
		if (c5x == null)
		{
			return dc4.e;
		}
		ar7 classPropertyValue = base.vg().q().d().a().GetClassPropertyValue<ar7>(bah.c);
		if (classPropertyValue != null && classPropertyValue.ao() != null)
		{
			bdf aspect = classPropertyValue.ao().GetAspect<bdf>();
			if (aspect != null && aspect.f() != null && aspect.f().ao() == base.vg().q())
			{
				aspect.r9(false);
			}
		}
		if (c5x.GetAspect<bim>() is wv)
		{
			as7 @as = c5x.GetAspect<bdf>() as as7;
			if (@as == null)
			{
				@as = new as7(c5x);
				@as.a(7f);
				@as.a(new l9?(l9.b));
				@as.b(3.5);
				@as.a(2.0);
				c5x.SetAspect<bdf>(@as);
			}
			@as.r8(base.vg().q(), false);
			return dc4.c;
		}
		atg atg = c5x.GetAspect<bdf>() as atg;
		if (atg != null)
		{
			atg.r8(base.vg().q(), false);
		}
		return dc4.e;
	}

	// Token: 0x06007F12 RID: 32530 RVA: 0x0035C4F4 File Offset: 0x0035A6F4
	public dmt()
	{
	}
}
