using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001E11 RID: 7697
[eiz("SS3")]
[Serializable]
public abstract class fc : csn, ISerializable
{
	// Token: 0x0600AA6A RID: 43626 RVA: 0x003F3D48 File Offset: 0x003F1F48
	protected fc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(fc);
		}
	}

	// Token: 0x0600AA6B RID: 43627 RVA: 0x003F3D74 File Offset: 0x003F1F74
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AA6C RID: 43628 RVA: 0x003F3D80 File Offset: 0x003F1F80
	public override SkillCategory fg()
	{
		return SkillCategory.Social;
	}

	// Token: 0x0600AA6D RID: 43629 RVA: 0x003F3D84 File Offset: 0x003F1F84
	protected fc(int A_0 = 0, ech A_1 = null) : base(A_0, A_1)
	{
	}
}
