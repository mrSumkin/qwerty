using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001781 RID: 6017
[z1("cleanDeal")]
internal sealed class axt : c1f
{
	// Token: 0x06008125 RID: 33061 RVA: 0x003676DC File Offset: 0x003658DC
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new dpw(SkillEnum.ThoughtControl.ToString().a(), 20),
			new ax6(BaseAbilityEnum.Perception.ToString(), -1),
			new ciw(-30)
		};
		A_1 = null;
		A_2 = null;
	}
}
