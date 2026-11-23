using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001788 RID: 6024
[z1("whiteDude")]
internal sealed class a8p : c1f
{
	// Token: 0x06008135 RID: 33077 RVA: 0x00367958 File Offset: 0x00365B58
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new ax6(BaseAbilityEnum.Agility.ToString(), 3),
			new ax6(BaseAbilityEnum.Dexterity.ToString(), -2),
			new ax6(BaseAbilityEnum.Perception.ToString(), -2),
			new dpw(SkillEnum.Persuasion.ToString(), 15),
			new emn(-30)
		};
		A_1 = null;
		A_2 = null;
	}
}
