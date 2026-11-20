using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x0200104F RID: 4175
[eiz("WCARJ")]
[Serializable]
public sealed class aku : cze, ISerializable
{
	// Token: 0x06005695 RID: 22165 RVA: 0x0025FA84 File Offset: 0x0025DC84
	private aku(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005696 RID: 22166 RVA: 0x0025FA90 File Offset: 0x0025DC90
	public aku()
	{
	}

	// Token: 0x06005697 RID: 22167 RVA: 0x0025FA9C File Offset: 0x0025DC9C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(A_1.RaysEmitters), new Func<bsf, bool>(aku.a.a.a)));
		if (bsf != null)
		{
			bsf.ig();
		}
	}

	// Token: 0x02001050 RID: 4176
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600569A RID: 22170 RVA: 0x0025FB04 File Offset: 0x0025DD04
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "wirelessChargingAura";
		}

		// Token: 0x0400231D RID: 8989
		public static readonly aku.a a = new aku.a();

		// Token: 0x0400231E RID: 8990
		public static Func<bsf, bool> b;
	}
}
