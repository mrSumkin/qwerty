using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001ABA RID: 6842
[eiz("EISE")]
[Serializable]
public sealed class en9 : els, ISerializable
{
	// Token: 0x0600945B RID: 37979 RVA: 0x003A600C File Offset: 0x003A420C
	private en9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600945C RID: 37980 RVA: 0x003A601C File Offset: 0x003A421C
	public en9(PsiSchool A_0, int A_1) : base(en9.a, "Псионическое усиление", ci8.b)
	{
		this.b = A_0;
		base.Duration = A_1;
		base.Icon = "EmpoweredInvocation." + this.b.ToString();
		this.y = "EISEE";
		base.StaticEffects.Add(new bxb(this.b.ToString().a(), Convert.ToSingle(cch.b)));
	}

	// Token: 0x0600945D RID: 37981 RVA: 0x003A60A4 File Offset: 0x003A42A4
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/EmpoweredInvocation", new object[]
		{
			this.b.ToString().a(),
			Convert.ToInt32(cch.b * 100.0)
		});
	}

	// Token: 0x0400390B RID: 14603
	public new static readonly string a = "empoweredInvocation";

	// Token: 0x0400390C RID: 14604
	private PsiSchool b;
}
