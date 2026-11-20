using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001ADE RID: 6878
[eiz("IBSE")]
[Serializable]
public sealed class dzn : els, ISerializable
{
	// Token: 0x0600950A RID: 38154 RVA: 0x003A8758 File Offset: 0x003A6958
	private dzn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600950B RID: 38155 RVA: 0x003A8764 File Offset: 0x003A6964
	public dzn(int A_0, int A_1) : base(dzn.a, "Усиление интеллекта", ci8.b)
	{
		base.Duration = A_0;
		base.Power = A_1;
		base.Icon = "Status.IntelligenceBoost";
		base.ExpiredAction = "BlueExpirationAction";
		base.RemovedAction = "BlueExpirationAction";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Intelligence.ToString(), A_1));
	}

	// Token: 0x0600950C RID: 38156 RVA: 0x003A87D8 File Offset: 0x003A69D8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/IntelligenceBoost", new object[]
		{
			base.Power
		});
	}

	// Token: 0x04003962 RID: 14690
	public new static readonly string a = "intelligenceBoost";
}
