using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001E42 RID: 7746
[eiz("SS")]
[Serializable]
public abstract class r5 : csn, ISerializable
{
	// Token: 0x0600ABBF RID: 43967 RVA: 0x003F794C File Offset: 0x003F5B4C
	protected r5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(r5);
		}
	}

	// Token: 0x0600ABC0 RID: 43968 RVA: 0x003F7978 File Offset: 0x003F5B78
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600ABC1 RID: 43969 RVA: 0x003F7984 File Offset: 0x003F5B84
	public override SkillCategory fg()
	{
		return SkillCategory.Subterfuge;
	}

	// Token: 0x0600ABC2 RID: 43970 RVA: 0x003F7988 File Offset: 0x003F5B88
	protected r5(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}
}
