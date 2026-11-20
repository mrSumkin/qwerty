using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02001032 RID: 4146
[eiz("BLO8")]
[Serializable]
public sealed class bmu : cze
{
	// Token: 0x0600559E RID: 21918 RVA: 0x0025C0B8 File Offset: 0x0025A2B8
	private bmu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600559F RID: 21919 RVA: 0x0025C0C4 File Offset: 0x0025A2C4
	public bmu()
	{
	}

	// Token: 0x060055A0 RID: 21920 RVA: 0x0025C0D0 File Offset: 0x0025A2D0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && c5x.Area != null)
		{
			e1d aspect = c5x.GetAspect<e1d>();
			if (aspect != null)
			{
				ak1 ak = c5x.Area.a(c5x.aj().a());
				if (ak != null)
				{
					dd5.a(null, ak, (double)((int)d05.b(1.0, aspect.b(), 4.0)), int.MaxValue, false);
					bqt bqt = Enumerable.FirstOrDefault<bqt>(Enumerable.Where<bqt>(ak.TriggerProxies, new Func<bqt, bool>(bmu.a.a.a)));
					if (bqt != null)
					{
						bqt.Trigger.o();
					}
					c5x.w();
					c5x.an();
				}
			}
		}
	}

	// Token: 0x02001033 RID: 4147
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060055A3 RID: 21923 RVA: 0x0025C1B4 File Offset: 0x0025A3B4
		internal bool a(bqt A_0)
		{
			return A_0.Trigger is avy;
		}

		// Token: 0x040022D4 RID: 8916
		public static readonly bmu.a a = new bmu.a();

		// Token: 0x040022D5 RID: 8917
		public static Func<bqt, bool> b;
	}
}
