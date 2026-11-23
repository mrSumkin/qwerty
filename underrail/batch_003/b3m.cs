using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001E0D RID: 7693
[eiz("SS1")]
[Serializable]
public abstract class b3m : csn, ISerializable
{
	// Token: 0x0600AA58 RID: 43608 RVA: 0x003F3B04 File Offset: 0x003F1D04
	protected b3m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(b3m);
		}
	}

	// Token: 0x0600AA59 RID: 43609 RVA: 0x003F3B30 File Offset: 0x003F1D30
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AA5A RID: 43610 RVA: 0x003F3B3C File Offset: 0x003F1D3C
	public override SkillCategory fg()
	{
		return SkillCategory.Technology;
	}

	// Token: 0x0600AA5B RID: 43611 RVA: 0x003F3B40 File Offset: 0x003F1D40
	protected b3m(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AA5C RID: 43612 RVA: 0x003F3B4C File Offset: 0x003F1D4C
	protected override Dictionary<Type, float> fi()
	{
		return new Dictionary<Type, float>
		{
			{
				typeof(av8),
				1f
			}
		};
	}
}
