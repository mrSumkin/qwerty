using System;
using System.Runtime.CompilerServices;

// Token: 0x02000ED3 RID: 3795
[e79("Arena/BullsEyeFight")]
public sealed class d3i : ds5
{
	// Token: 0x06004DFF RID: 19967 RVA: 0x0022A308 File Offset: 0x00228508
	protected override string abn()
	{
		return "BullsEyeFightEnd";
	}

	// Token: 0x06004E00 RID: 19968 RVA: 0x0022A310 File Offset: 0x00228510
	protected override void abo(cnk A_0, c5x A_1)
	{
		d3i.a a = new d3i.a();
		a.a = A_0;
		btm[] array = new btm[1];
		int num = 0;
		dva dva = new dva(null, null, null, null, null);
		dva.a(new Func<e6d, bool>(a.a));
		array[num] = dva;
		base.a(array);
	}

	// Token: 0x06004E01 RID: 19969 RVA: 0x0022A358 File Offset: 0x00228558
	protected override void abp(cnk A_0, c5x A_1)
	{
		base.a("Снова добро пожаловать, мои кровожадные маньяки!", 4);
		base.a("Только что мы видели, как Потрошилла доминировала этих двух несчастных претендентов!", 5);
		base.a("Прекрасная бойня! ПРЕ-КРАС-НА-Я!", 4);
		base.a("А сейчас мы увидим, как старый добрый Аспид сразится с одним из наших молодых кровожадных претендентов.", 4);
		base.a("Приветствуйте...", 4);
	}

	// Token: 0x06004E02 RID: 19970 RVA: 0x0022A3A4 File Offset: 0x002285A4
	protected override void abq(cnk A_0, c5x A_1)
	{
		base.a(A_0.aqu().v().Name + "!", 4);
		base.a("Вперёд! Нам покажите вы кровопролитие!", 4);
	}

	// Token: 0x02000ED4 RID: 3796
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E05 RID: 19973 RVA: 0x0022A3F4 File Offset: 0x002285F4
		internal bool a(e6d A_0)
		{
			csd a_ = this.a.aqw().g("enemyGladiator");
			vq.a("creatures\\arena\\BullsEye", a_, false);
			return true;
		}

		// Token: 0x04001FDB RID: 8155
		public cnk a;
	}
}
