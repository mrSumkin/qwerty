using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02000ADF RID: 2783
[eiz("XPBLSAJ")]
[Serializable]
public sealed class eas : cze, ISerializable
{
	// Token: 0x060040D3 RID: 16595 RVA: 0x0018B644 File Offset: 0x00189844
	private eas(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040D4 RID: 16596 RVA: 0x0018B650 File Offset: 0x00189850
	public eas()
	{
	}

	// Token: 0x060040D5 RID: 16597 RVA: 0x0018B658 File Offset: 0x00189858
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_2 != null)
		{
			List<csk> list = A_2.SafeGet("damage", null);
			if (list != null)
			{
				if (Enumerable.Sum<csk>(list, new Func<csk, int>(eas.a.a.a)) > 0)
				{
					cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
					serviceOrThrow.aqu().r()[bvw.i] = true;
					serviceOrThrow.aqu().r()[bvw.j] = true;
					serviceOrThrow.aqu().r()[bvw.l] = true;
				}
			}
		}
	}

	// Token: 0x02000AE0 RID: 2784
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060040D8 RID: 16600 RVA: 0x0018B718 File Offset: 0x00189918
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04001C07 RID: 7175
		public static readonly eas.a a = new eas.a();

		// Token: 0x04001C08 RID: 7176
		public static Func<csk, int> b;
	}
}
