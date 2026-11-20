using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x020016B5 RID: 5813
[eiz("CTA7")]
[Serializable]
public sealed class cx5 : a6k, ISerializable
{
	// Token: 0x06007ECF RID: 32463 RVA: 0x0035939C File Offset: 0x0035759C
	private cx5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007ED0 RID: 32464 RVA: 0x003593A8 File Offset: 0x003575A8
	public cx5()
	{
	}

	// Token: 0x06007ED1 RID: 32465 RVA: 0x003593B0 File Offset: 0x003575B0
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null)
		{
			amc b = c5x.h.b;
			if (b != null)
			{
				cd1 cd = b.aa().Offense.u();
				if (cd != null && euf.k(cd) && cd.LoadedAmmo.Count == 2)
				{
					AmmoType value = cd.LoadedAmmo[0];
					cd.LoadedAmmo[0] = cd.LoadedAmmo[1];
					cd.LoadedAmmo[1] = value;
					return dc4.c;
				}
			}
		}
		return dc4.e;
	}
}
