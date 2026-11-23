using System;
using System.Runtime.CompilerServices;

// Token: 0x02000EDD RID: 3805
[e79("Arena/SurgeonFight")]
public sealed class cck : ds5
{
	// Token: 0x06004E1C RID: 19996 RVA: 0x0022A9C4 File Offset: 0x00228BC4
	protected override string abn()
	{
		return "SurgeonFightEnd";
	}

	// Token: 0x06004E1D RID: 19997 RVA: 0x0022A9D0 File Offset: 0x00228BD0
	protected override void abo(cnk A_0, c5x A_1)
	{
		cck.a a = new cck.a();
		a.a = A_0;
		btm[] array = new btm[1];
		int num = 0;
		dva dva = new dva(null, null, null, null, null);
		dva.a(new Func<e6d, bool>(a.a));
		array[num] = dva;
		base.a(array);
	}

	// Token: 0x06004E1E RID: 19998 RVA: 0x0022AA18 File Offset: 0x00228C18
	protected override void abp(cnk A_0, c5x A_1)
	{
		base.a("Врачи обожают кровь и кишки, дорогие маньяки. Зачем ещё они бы стали вскрывать людишек, позвольте спросить?", 4);
	}

	// Token: 0x06004E1F RID: 19999 RVA: 0x0022AA28 File Offset: 0x00228C28
	protected override void abq(cnk A_0, c5x A_1)
	{
		base.a("Вы его знаете, вы его любите! Это Хирург!", 4);
		base.a("Но знаете ли вы, кто ещё любит кровь и мясо?", 4);
		base.a("Судя по вашим воплям, дорогие маньяки, ещё как знаете!", 4);
		object obj = A_0.aqu().r()["playerArenaTitle"];
		base.a(((obj != null) ? obj.ToString() : null) + "!", 3);
		base.a("Чьи кишки прольются сегодня?! Мы вот-вот увидим!", 4);
	}

	// Token: 0x02000EDE RID: 3806
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E22 RID: 20002 RVA: 0x0022AAB4 File Offset: 0x00228CB4
		internal bool a(e6d A_0)
		{
			csd a_ = this.a.aqw().g("enemyGladiator");
			vq.a("creatures\\arena\\Surgeon", a_, false);
			return true;
		}

		// Token: 0x04001FDE RID: 8158
		public cnk a;
	}
}
