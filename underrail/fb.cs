using System;
using System.Runtime.Serialization;

// Token: 0x02001877 RID: 6263
[eiz("S2")]
[Serializable]
public sealed class fb : eps, ISerializable
{
	// Token: 0x06008529 RID: 34089 RVA: 0x003759E4 File Offset: 0x00373BE4
	private fb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600852A RID: 34090 RVA: 0x003759F0 File Offset: 0x00373BF0
	public fb()
	{
		s5 s = new s5();
		s.e().b(bat.a);
		s.a(new bt4("spinLoc1"));
		s5 s2 = new s5();
		s2.e().b(bat.a);
		s2.a(new bt4("spinLoc2"));
		s5 s3 = new s5();
		s3.e().b(bat.a);
		s3.a(new bt4("spinLoc3"));
		s5 s4 = new s5();
		s4.e().b(bat.a);
		s4.a(new bt4("npcStart"));
		base.a(new btm[]
		{
			s,
			s2,
			s3,
			s4
		});
	}

	// Token: 0x0600852B RID: 34091 RVA: 0x00375AB8 File Offset: 0x00373CB8
	public override bool fe(object A_0)
	{
		bm6 bm = A_0 as bm6;
		return bm != null && bm.y6() != null && ((bm.a8().h.b != null && (!bm.a8().h.b.aa().IsInControl || bm.a8().h.b.aa().IsInCombat)) || new bzv(bm.y6()).f() > 0);
	}

	// Token: 0x0600852C RID: 34092 RVA: 0x00375B48 File Offset: 0x00373D48
	public override bool ff(object A_0)
	{
		bm6 bm = A_0 as bm6;
		return bm != null && bm.y6() != null && (bm.a8().h.b == null || (bm.a8().h.b.aa().IsInControl && !bm.a8().h.b.aa().IsInCombat)) && new bzv(bm.y6()).f() == 0;
	}
}
