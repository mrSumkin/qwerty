using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001AE2 RID: 6882
[eiz("STS1")]
[Serializable]
public sealed class amy : els, ISerializable, sj
{
	// Token: 0x06009519 RID: 38169 RVA: 0x003A8AC0 File Offset: 0x003A6CC0
	private amy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 698)
		{
			this.b = A_0.GetInt32("STS1:R");
		}
	}

	// Token: 0x0600951A RID: 38170 RVA: 0x003A8AEC File Offset: 0x003A6CEC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("STS1:R", this.b);
	}

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x0600951B RID: 38171 RVA: 0x003A8B08 File Offset: 0x003A6D08
	public override bool Refreshable
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600951C RID: 38172 RVA: 0x003A8B0C File Offset: 0x003A6D0C
	public amy(int A_0, int A_1) : base(amy.a, "Стазис", ci8.a)
	{
		base.Icon = "Psi.Stasis";
		base.VisualEffects.Add(new ud(this, "Stasis"));
		base.Duration = A_0;
		this.b = A_1;
		this.aa = "OnStasisRemoved";
		base.StaticEffects.Add(new eab());
		base.StaticEffects.Add(new a1s());
		base.StaticEffects.Add(new awe(CharacterImmunities.Stun));
		base.StaticEffects.Add(new awe(CharacterImmunities.Incapacitation));
		base.StaticEffects.Add(new awe(CharacterImmunities.Freeze));
		base.StaticEffects.Add(new awe(CharacterImmunities.Daze));
		base.StaticEffects.Add(new awe(CharacterImmunities.MindAffecting));
		base.StaticEffects.Add(new awe(CharacterImmunities.Fear));
	}

	// Token: 0x0600951D RID: 38173 RVA: 0x003A8BFC File Offset: 0x003A6DFC
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Stasis", new object[]
		{
			this.b
		});
	}

	// Token: 0x04003965 RID: 14693
	public new static readonly string a = "stasis";

	// Token: 0x04003966 RID: 14694
	public int b;
}
