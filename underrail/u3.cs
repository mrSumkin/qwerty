using System;
using System.Collections.Generic;

// Token: 0x02001CC8 RID: 7368
[d29("Riposte", "Riposte")]
public sealed class u3 : ai8
{
	// Token: 0x0600A1A9 RID: 41385 RVA: 0x003E7BC8 File Offset: 0x003E5DC8
	public u3() : base("膦Ответный удар")
	{
	}

	// Token: 0x0600A1AA RID: 41386 RVA: 0x003E7BD8 File Offset: 0x003E5DD8
	public override string au()
	{
		return "xpbl";
	}

	// Token: 0x0600A1AB RID: 41387 RVA: 0x003E7BE0 File Offset: 0x003E5DE0
	public override bool ap()
	{
		return false;
	}

	// Token: 0x0600A1AC RID: 41388 RVA: 0x003E7BE4 File Offset: 0x003E5DE4
	public override void ar(efk A_0)
	{
		A_0.SpecialAttacks.b(dgk.Get<bch>());
	}

	// Token: 0x0600A1AD RID: 41389 RVA: 0x003E7BF8 File Offset: 0x003E5DF8
	public override void @as(efk A_0)
	{
		A_0.SpecialAttacks.a(dgk.Get<bch>());
	}

	// Token: 0x0600A1AE RID: 41390 RVA: 0x003E7C0C File Offset: 0x003E5E0C
	public override List<brl> j0()
	{
		return new List<brl>
		{
			new awr(typeof(cwu), 7),
			new bap(40, new Type[]
			{
				typeof(jk)
			}),
			new b4k(new Type[]
			{
				typeof(du9)
			})
		};
	}
}
