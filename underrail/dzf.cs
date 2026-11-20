using System;
using System.Runtime.Serialization;

// Token: 0x020017C5 RID: 6085
[eiz("TUPMA")]
[Serializable]
public sealed class dzf : a6k, ISerializable
{
	// Token: 0x060081DB RID: 33243 RVA: 0x0036A99C File Offset: 0x00368B9C
	private dzf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060081DC RID: 33244 RVA: 0x0036A9A8 File Offset: 0x00368BA8
	public dzf()
	{
	}

	// Token: 0x060081DD RID: 33245 RVA: 0x0036A9B0 File Offset: 0x00368BB0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		coh coh = base.vg().e().b9() as coh;
		if (coh != null)
		{
			eml eml = coh.Definition as eml;
			au2 au = base.vg().q().h.b.aa() as au2;
			if (eml != null && au != null && !string.IsNullOrEmpty(eml.b()) && au != null)
			{
				c3n c3n = dgk.a(eml.b());
				if (c3n is c7i && !au.PsiAbilities.c(c3n))
				{
					ay5 ay = new ay5();
					ay.a(eml.b());
					ay.a(true);
					ay.ym(null, null, null);
					return dc4.c;
				}
			}
		}
		return dc4.e;
	}
}
