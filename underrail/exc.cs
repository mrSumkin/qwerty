using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001E31 RID: 7729
[eiz("DS")]
[Serializable]
public abstract class exc : csn, ISerializable
{
	// Token: 0x0600AB44 RID: 43844 RVA: 0x003F62E8 File Offset: 0x003F44E8
	protected exc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(exc);
		}
	}

	// Token: 0x0600AB45 RID: 43845 RVA: 0x003F6314 File Offset: 0x003F4514
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AB46 RID: 43846 RVA: 0x003F6320 File Offset: 0x003F4520
	protected exc(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AB47 RID: 43847 RVA: 0x003F632C File Offset: 0x003F452C
	public override SkillCategory fg()
	{
		return SkillCategory.Defense;
	}
}
