using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules;

// Token: 0x020018FD RID: 6397
public static class aiy
{
	// Token: 0x060087EF RID: 34799 RVA: 0x0038510C File Offset: 0x0038330C
	static aiy()
	{
		aiy.b3 = new Dictionary<cem, double>();
		aiy.b3[cem.a] = 100.0;
		aiy.b3[cem.b] = 100.0;
		aiy.b3[cem.c] = 100.0;
		aiy.b3[cem.d] = 200.0;
		aiy.co = new Dictionary<db9, int>();
		aiy.co[db9.a] = 0;
		aiy.co[db9.b] = 20;
		aiy.co[db9.c] = 30;
		aiy.co[db9.d] = 40;
		aiy.cp = new GameDifficultySettings[4];
		aiy.cp[0] = new GameDifficultySettings
		{
			EncounterDifficulty = GameDifficulty.Easy,
			PuzzleDifficulty = GameDifficulty.Easy,
			PlayerHealthModifier = 3f,
			NpcHealthModifier = 0.5f,
			NpcBossHealthModifier = 1f,
			HealingModifier = 2f,
			NpcSkillModifier = 1f,
			NpcBossSkillModifier = 1f,
			NpcCritChanceBonus = 0f,
			ZoneTransitionApCost = 0,
			SoldItemValueModifier = 1f,
			HealingCooldown = 2
		};
		aiy.cp[1] = new GameDifficultySettings
		{
			EncounterDifficulty = GameDifficulty.Normal,
			PuzzleDifficulty = GameDifficulty.Normal,
			PlayerHealthModifier = 1.5f,
			NpcHealthModifier = 1f,
			NpcBossHealthModifier = 1f,
			HealingModifier = 1f,
			NpcSkillModifier = 1f,
			NpcBossSkillModifier = 1f,
			NpcCritChanceBonus = 0f,
			ZoneTransitionApCost = 25,
			SoldItemValueModifier = 1f,
			HealingCooldown = 6
		};
		aiy.cp[2] = new GameDifficultySettings
		{
			EncounterDifficulty = GameDifficulty.Hard,
			PuzzleDifficulty = GameDifficulty.Hard,
			PlayerHealthModifier = 1f,
			NpcHealthModifier = 1.5f,
			NpcBossHealthModifier = 1.5f,
			HealingModifier = 0.5f,
			NpcSkillModifier = 1f,
			NpcBossSkillModifier = 1f,
			NpcCritChanceBonus = 0f,
			ZoneTransitionApCost = 40,
			SoldItemValueModifier = 0.5f,
			HealingCooldown = 12
		};
		aiy.cp[3] = new GameDifficultySettings
		{
			EncounterDifficulty = GameDifficulty.Dominating,
			PuzzleDifficulty = GameDifficulty.Dominating,
			PlayerHealthModifier = 1f,
			NpcHealthModifier = 2f,
			NpcBossHealthModifier = 4f,
			HealingModifier = 0.5f,
			NpcSkillModifier = 1.3f,
			NpcBossSkillModifier = 2f,
			NpcCritChanceBonus = 0.03f,
			ZoneTransitionApCost = 40,
			SoldItemValueModifier = 0.25f,
			HealingCooldown = 12
		};
	}

	// Token: 0x060087F0 RID: 34800 RVA: 0x003857AC File Offset: 0x003839AC
	public static c6m a(efk A_0, int A_1)
	{
		return new aiy.a(aiy.a(A_0), A_1);
	}

	// Token: 0x060087F1 RID: 34801 RVA: 0x003857BC File Offset: 0x003839BC
	public static Type a(efk A_0)
	{
		Type typeFromHandle;
		if (A_0 != null && A_0.Feats.Contains<ck5>())
		{
			typeFromHandle = typeof(axr);
		}
		else
		{
			typeFromHandle = typeof(av8);
		}
		return typeFromHandle;
	}

	// Token: 0x040035F0 RID: 13808
	public static readonly float a = 4f;

	// Token: 0x040035F1 RID: 13809
	public static readonly float b = 5f;

	// Token: 0x040035F2 RID: 13810
	public static readonly int c = 10;

	// Token: 0x040035F3 RID: 13811
	public static readonly float d = 1.15f;

	// Token: 0x040035F4 RID: 13812
	public static readonly float e = 0.1f;

	// Token: 0x040035F5 RID: 13813
	public static readonly float f = 13f;

	// Token: 0x040035F6 RID: 13814
	public static readonly int g = 50;

	// Token: 0x040035F7 RID: 13815
	public static readonly int h = 30;

	// Token: 0x040035F8 RID: 13816
	public static readonly int i = 5;

	// Token: 0x040035F9 RID: 13817
	public static readonly int j = 3;

	// Token: 0x040035FA RID: 13818
	public static readonly int k = 5;

	// Token: 0x040035FB RID: 13819
	public static readonly double l = 0.03;

	// Token: 0x040035FC RID: 13820
	public static readonly int m = 35;

	// Token: 0x040035FD RID: 13821
	public static readonly int n = 100;

	// Token: 0x040035FE RID: 13822
	public static readonly int o = 300;

	// Token: 0x040035FF RID: 13823
	public static readonly int p = 0;

	// Token: 0x04003600 RID: 13824
	public static readonly int q = 10;

	// Token: 0x04003601 RID: 13825
	public static readonly double r = 1.25;

	// Token: 0x04003602 RID: 13826
	public static readonly int s = 5;

	// Token: 0x04003603 RID: 13827
	public static readonly int t = 5;

	// Token: 0x04003604 RID: 13828
	public static readonly int u = 4;

	// Token: 0x04003605 RID: 13829
	public static readonly int v = 1;

	// Token: 0x04003606 RID: 13830
	public static readonly int w = 10;

	// Token: 0x04003607 RID: 13831
	public static readonly int x = 10;

	// Token: 0x04003608 RID: 13832
	public static readonly int y = 3;

	// Token: 0x04003609 RID: 13833
	public static readonly int z = 4;

	// Token: 0x0400360A RID: 13834
	public static readonly float aa = 0.1f;

	// Token: 0x0400360B RID: 13835
	public static readonly float ab = 0.085f;

	// Token: 0x0400360C RID: 13836
	public static readonly double ac = 0.7;

	// Token: 0x0400360D RID: 13837
	public static readonly double ad = 0.75;

	// Token: 0x0400360E RID: 13838
	public static readonly double ae = 0.05;

	// Token: 0x0400360F RID: 13839
	public static readonly int af = 10;

	// Token: 0x04003610 RID: 13840
	public static readonly int ag = 5;

	// Token: 0x04003611 RID: 13841
	public static readonly int ah = 0;

	// Token: 0x04003612 RID: 13842
	public static readonly int ai = 40;

	// Token: 0x04003613 RID: 13843
	public static readonly int aj = 5;

	// Token: 0x04003614 RID: 13844
	public static readonly int ak = 3;

	// Token: 0x04003615 RID: 13845
	public static readonly int al = 2;

	// Token: 0x04003616 RID: 13846
	public static readonly int am = 2;

	// Token: 0x04003617 RID: 13847
	public static readonly int an = 15;

	// Token: 0x04003618 RID: 13848
	public static readonly int ao = 1;

	// Token: 0x04003619 RID: 13849
	public static readonly int ap = 100;

	// Token: 0x0400361A RID: 13850
	public static readonly int aq = 5;

	// Token: 0x0400361B RID: 13851
	public static readonly int ar = 15;

	// Token: 0x0400361C RID: 13852
	public static readonly float @as = 0.1f;

	// Token: 0x0400361D RID: 13853
	public static readonly float at = 5f;

	// Token: 0x0400361E RID: 13854
	public static readonly int au = 11;

	// Token: 0x0400361F RID: 13855
	public static readonly int av = 8;

	// Token: 0x04003620 RID: 13856
	public static readonly double aw = 0.1;

	// Token: 0x04003621 RID: 13857
	public static readonly int ax = 2;

	// Token: 0x04003622 RID: 13858
	public static readonly int ay = 6;

	// Token: 0x04003623 RID: 13859
	public static readonly double az = 0.95;

	// Token: 0x04003624 RID: 13860
	public static readonly int a0 = 30;

	// Token: 0x04003625 RID: 13861
	public static readonly float a1 = 4f;

	// Token: 0x04003626 RID: 13862
	public static readonly float a2 = 4f;

	// Token: 0x04003627 RID: 13863
	public static readonly float a3 = 1.2f;

	// Token: 0x04003628 RID: 13864
	public static readonly float a4 = 0.85f;

	// Token: 0x04003629 RID: 13865
	public static readonly double a5 = 0.2;

	// Token: 0x0400362A RID: 13866
	public static readonly int a6 = 2000;

	// Token: 0x0400362B RID: 13867
	public static readonly float a7 = 0.01f;

	// Token: 0x0400362C RID: 13868
	public static readonly int a8 = 30;

	// Token: 0x0400362D RID: 13869
	public static readonly int a9 = 40;

	// Token: 0x0400362E RID: 13870
	public static readonly int ba = 50;

	// Token: 0x0400362F RID: 13871
	public static readonly int bb = 20;

	// Token: 0x04003630 RID: 13872
	public static readonly int bc = 4;

	// Token: 0x04003631 RID: 13873
	public static readonly float bd = 0.8f;

	// Token: 0x04003632 RID: 13874
	public static readonly float be = 0.15f;

	// Token: 0x04003633 RID: 13875
	public static readonly int bf = 30;

	// Token: 0x04003634 RID: 13876
	public static readonly int bg = 3;

	// Token: 0x04003635 RID: 13877
	public static readonly int bh = 1000;

	// Token: 0x04003636 RID: 13878
	public static readonly int bi = 10000;

	// Token: 0x04003637 RID: 13879
	public static readonly int bj = 2500;

	// Token: 0x04003638 RID: 13880
	public static readonly int bk = 25;

	// Token: 0x04003639 RID: 13881
	public static readonly int bl = 5;

	// Token: 0x0400363A RID: 13882
	public static readonly int bm = 30;

	// Token: 0x0400363B RID: 13883
	public static readonly int bn = 20;

	// Token: 0x0400363C RID: 13884
	public static readonly int bo = 1;

	// Token: 0x0400363D RID: 13885
	public static readonly int bp = 4;

	// Token: 0x0400363E RID: 13886
	public static readonly int bq = 2;

	// Token: 0x0400363F RID: 13887
	public static readonly int br = 30;

	// Token: 0x04003640 RID: 13888
	public static readonly int bs = 1;

	// Token: 0x04003641 RID: 13889
	public static readonly int bt = 30;

	// Token: 0x04003642 RID: 13890
	public static readonly int bu = 70;

	// Token: 0x04003643 RID: 13891
	public static readonly int bv = 75;

	// Token: 0x04003644 RID: 13892
	public static readonly int bw = 5;

	// Token: 0x04003645 RID: 13893
	public static readonly int bx = 6000;

	// Token: 0x04003646 RID: 13894
	public static readonly float by = 0.75f;

	// Token: 0x04003647 RID: 13895
	public static readonly float bz = 0.45f;

	// Token: 0x04003648 RID: 13896
	public static readonly float b0 = 0.3f;

	// Token: 0x04003649 RID: 13897
	public static readonly int b1 = 0;

	// Token: 0x0400364A RID: 13898
	public static readonly int b2 = 15;

	// Token: 0x0400364B RID: 13899
	public static readonly Dictionary<cem, double> b3;

	// Token: 0x0400364C RID: 13900
	public static readonly double b4 = 0.1;

	// Token: 0x0400364D RID: 13901
	public static readonly double b5 = 0.03;

	// Token: 0x0400364E RID: 13902
	public static readonly double b6 = 0.5;

	// Token: 0x0400364F RID: 13903
	public static readonly double b7 = 0.1;

	// Token: 0x04003650 RID: 13904
	public static readonly double b8 = 1.0;

	// Token: 0x04003651 RID: 13905
	public static readonly double b9 = 1.5;

	// Token: 0x04003652 RID: 13906
	public static readonly double ca = 2.25;

	// Token: 0x04003653 RID: 13907
	public static readonly double cb = 75.0;

	// Token: 0x04003654 RID: 13908
	public static readonly double cc = 105.0;

	// Token: 0x04003655 RID: 13909
	public static readonly double cd = 0.5;

	// Token: 0x04003656 RID: 13910
	public static readonly double ce = 0.8;

	// Token: 0x04003657 RID: 13911
	public static readonly double cf = 0.0;

	// Token: 0x04003658 RID: 13912
	public static readonly double cg = 2.5;

	// Token: 0x04003659 RID: 13913
	public static readonly double ch = 0.5;

	// Token: 0x0400365A RID: 13914
	public static readonly double ci = 0.65;

	// Token: 0x0400365B RID: 13915
	public static readonly double cj = 0.95;

	// Token: 0x0400365C RID: 13916
	public static readonly int ck = 100;

	// Token: 0x0400365D RID: 13917
	public static readonly int cl = 10;

	// Token: 0x0400365E RID: 13918
	public static readonly double cm = 1.25;

	// Token: 0x0400365F RID: 13919
	public static readonly double cn = 1.5;

	// Token: 0x04003660 RID: 13920
	public static Dictionary<db9, int> co;

	// Token: 0x04003661 RID: 13921
	public static GameDifficultySettings[] cp;

	// Token: 0x020018FE RID: 6398
	private class a : c6m
	{
		// Token: 0x060087F2 RID: 34802 RVA: 0x003857FC File Offset: 0x003839FC
		public a(Type A_0, int A_1)
		{
			this.a = A_1;
			this.b = new List<brl>();
			if (A_1 > 1)
			{
				this.b.Add(new awr(A_0, (A_1 - 1) * 2));
			}
		}

		// Token: 0x060087F3 RID: 34803 RVA: 0x00385834 File Offset: 0x00383A34
		public List<brl> j0()
		{
			return this.b;
		}

		// Token: 0x04003662 RID: 13922
		public int a;

		// Token: 0x04003663 RID: 13923
		public List<brl> b;
	}
}
