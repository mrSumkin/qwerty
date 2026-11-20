using System;
using System.Runtime.Serialization;

// Token: 0x0200147D RID: 5245
[eiz("SIF")]
[Serializable]
public sealed class ahf : a6k, ISerializable
{
	// Token: 0x06007657 RID: 30295 RVA: 0x003206D0 File Offset: 0x0031E8D0
	private ahf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007658 RID: 30296 RVA: 0x003206DC File Offset: 0x0031E8DC
	public ahf()
	{
	}

	// Token: 0x06007659 RID: 30297 RVA: 0x003206E8 File Offset: 0x0031E8E8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		coh coh = base.vg().e().b9() as coh;
		if (coh != null && coh.Definition != null)
		{
			string classPropertyValue = coh.Definition.a7().GetClassPropertyValue<string>("InterfaceDialog");
			string classPropertyValue2 = coh.Definition.a7().GetClassPropertyValue<string>("InterfaceActorName");
			string classPropertyValue3 = coh.Definition.a7().GetClassPropertyValue<string>("InterfaceActorId");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				a72 a = new a72();
				a.a(true);
				a.b(true);
				a.b(classPropertyValue);
				a.c(classPropertyValue2);
				if (!string.IsNullOrEmpty(classPropertyValue3))
				{
					a.d(classPropertyValue3);
				}
				a.c(false);
				a.ym(c5x, c5x, null);
			}
		}
		return dc4.c;
	}
}
