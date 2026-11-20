using System;
using System.Runtime.CompilerServices;

// Token: 0x02000ED0 RID: 3792
[e79("Arena/PulverizerFight")]
public sealed class cph : ds5
{
	// Token: 0x06004DF6 RID: 19958 RVA: 0x0022A188 File Offset: 0x00228388
	protected override string abn()
	{
		return "PulverizerFightEnd";
	}

	// Token: 0x06004DF7 RID: 19959 RVA: 0x0022A190 File Offset: 0x00228390
	protected override void abo(cnk A_0, c5x A_1)
	{
		cph.a a = new cph.a();
		a.a = A_0;
		btm[] array = new btm[1];
		int num = 0;
		dva dva = new dva(null, null, null, null, null);
		dva.a(new Func<e6d, bool>(a.a));
		array[num] = dva;
		base.a(array);
	}

	// Token: 0x06004DF8 RID: 19960 RVA: 0x0022A1D8 File Offset: 0x002283D8
	protected override void abp(cnk A_0, c5x A_1)
	{
		base.a("И снова добро пожаловать, мои кровожадные маньяки!", 4);
		base.a("Мы собрались здесь сегодня чтобы увидеть и насладиться свирепой схваткой между этими двумя претендентами!", 4);
	}

	// Token: 0x06004DF9 RID: 19961 RVA: 0x0022A1F4 File Offset: 0x002283F4
	protected override void abq(cnk A_0, c5x A_1)
	{
		base.a("Сперва, поприветствуем Крушителя!", 4);
		base.a("Этот бывший гладиатор, а теперь обычный претендент \u0097 из-за некоторых очень, очень неудачных решений, принятых им в прошлом \u0097 по-прежнему сражается с неослабевающей свирепой жестокостью!", 6);
		base.a("А с другой стороны у нас " + A_0.aqu().v().Name + " \u0097 наш молодой и многообещающий претендент!", 4);
		base.a("Прольётся ли сегодня молодая кровь претендента? Давайте узнаем!", 4);
	}

	// Token: 0x02000ED1 RID: 3793
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004DFC RID: 19964 RVA: 0x0022A260 File Offset: 0x00228460
		internal bool a(e6d A_0)
		{
			csd a_ = this.a.aqw().g("enemyGladiator");
			vq.a("creatures\\arena\\pulverizer", a_, false);
			return true;
		}

		// Token: 0x04001FDA RID: 8154
		public cnk a;
	}
}
