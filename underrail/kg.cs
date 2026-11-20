using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02001415 RID: 5141
[eiz("AECW")]
[Serializable]
public class kg : enp, ISerializable
{
	// Token: 0x06007364 RID: 29540 RVA: 0x0030A2D0 File Offset: 0x003084D0
	private kg(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("AECW:IC", typeof(enp)) as enp);
		this.b = A_0.GetString("AECW:HVE");
		this.c = A_0.GetString("AECW:RVE");
		this.d = A_0.GetString("AECW:HSE");
		this.e = A_0.GetString("AECW:RSE");
		if (ell.a() >= 299)
		{
			this.f = A_0.GetSingle("AECW:HNV");
			this.g = A_0.GetSingle("AECW:RNV");
		}
	}

	// Token: 0x06007365 RID: 29541 RVA: 0x0030A378 File Offset: 0x00308578
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("AECW:IC", this.a);
		info.AddValue("AECW:HVE", this.b);
		info.AddValue("AECW:RVE", this.c);
		info.AddValue("AECW:HSE", this.d);
		info.AddValue("AECW:RSE", this.e);
		info.AddValue("AECW:HNV", this.f);
		info.AddValue("AECW:RNV", this.g);
	}

	// Token: 0x06007366 RID: 29542 RVA: 0x0030A3FC File Offset: 0x003085FC
	public kg(enp A_0, string A_1, string A_2, string A_3, string A_4, float A_5, float A_6)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
		this.f = A_5;
		this.g = A_6;
	}

	// Token: 0x06007367 RID: 29543 RVA: 0x0030A43C File Offset: 0x0030863C
	public void af(amc A_0, amc A_1, cwt A_2, cru A_3)
	{
		if (A_1 != null && A_1.a8() != null && A_1.a8().j == cgy.b && A_1.a8().Area != null && (A_2 == null || A_2.b))
		{
			bool flag;
			if (A_3.a != null)
			{
				flag = (Enumerable.Sum<csk>(A_3.a, new Func<csk, int>(kg.a.a.a)) == 0);
			}
			else
			{
				flag = true;
			}
			string text;
			string text2;
			float num;
			if (flag)
			{
				text = this.c;
				text2 = this.e;
				num = this.g;
			}
			else
			{
				text = this.b;
				text2 = this.d;
				num = this.f;
			}
			if (text != null)
			{
				c5x a_ = A_1.a8();
				string a_2 = text;
				int a_3 = 1;
				double maxValue = double.MaxValue;
				bool a_4 = true;
				bool a_5 = true;
				float? a_6 = dz6.b();
				boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
			}
			if (text2 != null)
			{
				bfq bfq = new bfq();
				bfq.a(bvl.b);
				bfq.c(text2);
				bfq.b("hit_" + Guid.NewGuid().ToString());
				bfq.ym(A_1.a8(), null, null);
				if (num > 0f)
				{
					ak1 ak = A_1.a8().Area.a(A_1.a8().aj().a());
					if (ak != null)
					{
						cn9 a_7 = new cn9(new edx(ak), (double)num);
						A_1.a8().Zone.ActionManager.g9(a_7, atp.a);
						dz6.a(a_7);
					}
				}
			}
			if (A_3.e > 0)
			{
				string a_8 = cf0.b(ai5.g, esu.b);
				bfq bfq2 = new bfq();
				bfq2.a(bvl.b);
				bfq2.c(a_8);
				bfq2.b("block_" + Guid.NewGuid().ToString());
				bfq2.ym(A_1.a8(), null, null);
			}
		}
		if (this.a != null)
		{
			this.a.af(A_0, A_1, A_2, A_3);
		}
	}

	// Token: 0x04002F27 RID: 12071
	private enp a;

	// Token: 0x04002F28 RID: 12072
	private string b;

	// Token: 0x04002F29 RID: 12073
	private string c;

	// Token: 0x04002F2A RID: 12074
	private string d;

	// Token: 0x04002F2B RID: 12075
	private string e;

	// Token: 0x04002F2C RID: 12076
	private float f;

	// Token: 0x04002F2D RID: 12077
	private float g;

	// Token: 0x02001416 RID: 5142
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600736A RID: 29546 RVA: 0x0030A684 File Offset: 0x00308884
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002F2E RID: 12078
		public static readonly kg.a a = new kg.a();

		// Token: 0x04002F2F RID: 12079
		public static Func<csk, int> b;
	}
}
