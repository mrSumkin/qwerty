using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020013CC RID: 5068
[bs6("HFX:DS")]
[eiz("DSHEA")]
[Serializable]
public sealed class b2k : cpl, ISerializable
{
	// Token: 0x06007215 RID: 29205 RVA: 0x002FF118 File Offset: 0x002FD318
	private b2k(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007216 RID: 29206 RVA: 0x002FF124 File Offset: 0x002FD324
	public b2k()
	{
	}

	// Token: 0x06007217 RID: 29207 RVA: 0x002FF12C File Offset: 0x002FD32C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.b() == null || base.agu() == null || base.b() == null || base.b().aa() == null)
		{
			return dc4.e;
		}
		if (!base.agw().b)
		{
			return dc4.c;
		}
		if (base.b().aa().Defense.i4() && (int)base.b().aa().Defense.i5() > 0)
		{
			int num = (int)Math.Min(base.b().aa().Defense.i5(), (double)k3.a(base.agu()));
			if (num > 0)
			{
				bool a_ = false;
				nw nw = base.b().aa().Defense;
				nw.c(nw.i5() - (double)num);
				if (base.b().a8().l.b != null)
				{
					base.b().a8().l.b.i();
				}
				if (base.a() != null && base.a().aa() != null)
				{
					vr a_2 = new vr(new ap9(base.b().aa()), new ap9(base.a().aa()), "{1}: атака рассеивается " + num.ToString() + " щита ({0}).", new Color?(adi.y), null);
					bey.a(a_2, base.b().aa(), base.b());
					a7v.a(a_2);
				}
				bmj.a(base.b().a8(), new bi2(num, a_));
			}
		}
		return dc4.c;
	}
}
