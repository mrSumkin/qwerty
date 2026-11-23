using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001775 RID: 6005
[eiz("TSCA")]
[Serializable]
public class dtb : qy, cst, aig, ISerializable
{
	// Token: 0x060080FC RID: 33020 RVA: 0x00366E18 File Offset: 0x00365018
	protected dtb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (m7)A_0.GetValue("TSCA:C", typeof(m7));
			return;
		}
		if (base.GetType() == typeof(dtb))
		{
			this.a = (m7)A_0.GetValue("_Categories", typeof(m7));
			return;
		}
		this.a = (m7)A_0.GetValue("TimelapseSequentialCompositeAction+_Categories", typeof(m7));
	}

	// Token: 0x060080FD RID: 33021 RVA: 0x00366EB4 File Offset: 0x003650B4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TSCA:C", this.a);
	}

	// Token: 0x060080FE RID: 33022 RVA: 0x00366ED8 File Offset: 0x003650D8
	public m7 kh()
	{
		m7 m = this.a;
		cst cst = base.aa() as cst;
		if (cst != null)
		{
			m |= cst.kh();
		}
		return m;
	}

	// Token: 0x060080FF RID: 33023 RVA: 0x00366F08 File Offset: 0x00365108
	public new void a(m7 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06008100 RID: 33024 RVA: 0x00366F14 File Offset: 0x00365114
	public dtb()
	{
	}

	// Token: 0x06008101 RID: 33025 RVA: 0x00366F1C File Offset: 0x0036511C
	public dtb(string A_0) : base(A_0)
	{
	}

	// Token: 0x06008102 RID: 33026 RVA: 0x00366F28 File Offset: 0x00365128
	public dtb(IEnumerable<auv> A_0) : base(A_0)
	{
	}

	// Token: 0x06008103 RID: 33027 RVA: 0x00366F34 File Offset: 0x00365134
	public dtb(string A_0, IEnumerable<auv> A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008104 RID: 33028 RVA: 0x00366F44 File Offset: 0x00365144
	public bool hj(b0b A_0, Vector3 A_1, Vector3 A_2, float A_3)
	{
		aig aig = base.aa() as aig;
		return aig != null && aig.hj(A_0, A_1, A_2, A_3);
	}

	// Token: 0x0400325D RID: 12893
	private new m7 a;
}
