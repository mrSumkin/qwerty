using System;
using System.Runtime.CompilerServices;

// Token: 0x02000ED6 RID: 3798
[e79("Arena/MasterExploderFight")]
public sealed class b8n : ds5
{
	// Token: 0x06004E08 RID: 19976 RVA: 0x0022A4E4 File Offset: 0x002286E4
	protected override string abn()
	{
		return "MasterExploderFightEnd";
	}

	// Token: 0x06004E09 RID: 19977 RVA: 0x0022A4F0 File Offset: 0x002286F0
	protected override void abo(cnk A_0, c5x A_1)
	{
		b8n.a a = new b8n.a();
		a.a = A_0;
		btm[] array = new btm[1];
		int num = 0;
		dva dva = new dva(null, null, null, null, null);
		dva.a(new Func<e6d, bool>(a.a));
		array[num] = dva;
		base.a(array);
	}

	// Token: 0x06004E0A RID: 19978 RVA: 0x0022A538 File Offset: 0x00228738
	protected override void abp(cnk A_0, c5x A_1)
	{
		base.a("Разве вы не любите смотреть как разлетаются оторванные конечности?!", 4);
		base.a("Наш ненаглядный Мастер-Детонатор уже много лет утоляет нашу жажду крови своим взрывным и пылающим характером!", 5);
		base.a("И сегодня он выйдет против новейшего члена нашей гладиаторской семьи!", 4);
		object obj = A_0.aqu().r()["playerArenaTitle"];
		base.a(((obj != null) ? obj.ToString() : null) + "!", 3);
		base.a("Этот молодой гладиатор не показывает ни жалости, ни страха! Только доминирование!", 4);
	}

	// Token: 0x06004E0B RID: 19979 RVA: 0x0022A5B0 File Offset: 0x002287B0
	protected override void abq(cnk A_0, c5x A_1)
	{
		base.a("Но не расстанется ли наш молодой гладиатор со своими конечностями в ходе этого боя?", 4);
		base.a("Что же, мы скоро сами всё увидим...", 4);
	}

	// Token: 0x02000ED7 RID: 3799
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004E0E RID: 19982 RVA: 0x0022A5E0 File Offset: 0x002287E0
		internal bool a(e6d A_0)
		{
			csd a_ = this.a.aqw().g("enemyGladiator");
			vq.a("creatures\\arena\\MasterExploder", a_, false);
			if (dk2.b("xphw"))
			{
				this.a.aqu().r()["loc_cc_arena_xphw_masterExploder_spawned"] = true;
			}
			return true;
		}

		// Token: 0x04001FDC RID: 8156
		public cnk a;
	}
}
