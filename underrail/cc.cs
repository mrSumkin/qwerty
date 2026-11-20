using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000ADD RID: 2781
[eiz("XPBLASBSEFJ")]
[Serializable]
public sealed class cc : cze, ISerializable
{
	// Token: 0x060040CD RID: 16589 RVA: 0x0018B250 File Offset: 0x00189450
	private cc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060040CE RID: 16590 RVA: 0x0018B25C File Offset: 0x0018945C
	public cc()
	{
	}

	// Token: 0x060040CF RID: 16591 RVA: 0x0018B264 File Offset: 0x00189464
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			c5x c5x = A_1 as c5x;
			if (c5x != null && c5x.p.b != null)
			{
				dtb dtb = new dtb();
				List<auv> list = dtb.ad();
				bi5 bi = new bi5();
				bi.a(new int?(1));
				bi.a(new float?((float)1));
				bi.a(true);
				a4s a4s = new a4s(bi, null, null, null);
				a4s.b(new ar7(A_1));
				list.Add(a4s);
				dtb.ad().Add(new bm3(200));
				List<auv> list2 = dtb.ad();
				bi5 bi2 = new bi5();
				bi2.a(new int?(1));
				bi2.a(new float?(0f));
				bi2.a(true);
				a4s a4s2 = new a4s(bi2, null, null, null);
				a4s2.b(new ar7(A_1));
				list2.Add(a4s2);
				dtb.ad().Add(new bm3(100));
				List<auv> list3 = dtb.ad();
				bi5 bi3 = new bi5();
				bi3.a(new int?(1));
				bi3.a(new float?((float)1));
				bi3.a(true);
				a4s a4s3 = new a4s(bi3, null, null, null);
				a4s3.b(new ar7(A_1));
				list3.Add(a4s3);
				dtb.ad().Add(new bm3(200));
				List<auv> list4 = dtb.ad();
				bi5 bi4 = new bi5();
				bi4.a(new int?(1));
				bi4.a(new float?(0f));
				bi4.a(true);
				a4s a4s4 = new a4s(bi4, null, null, null);
				a4s4.b(new ar7(A_1));
				list4.Add(a4s4);
				dtb.ad().Add(new bm3(150));
				List<auv> list5 = dtb.ad();
				bi5 bi5 = new bi5();
				bi5.a(new int?(1));
				bi5.a(new float?((float)1));
				bi5.a(true);
				a4s a4s5 = new a4s(bi5, null, null, null);
				a4s5.b(new ar7(A_1));
				list5.Add(a4s5);
				dtb.ad().Add(new bm3(200));
				List<auv> list6 = dtb.ad();
				bi5 bi6 = new bi5();
				bi6.a(new int?(1));
				bi6.a(new float?(0f));
				bi6.a(true);
				a4s a4s6 = new a4s(bi6, null, null, null);
				a4s6.b(new ar7(A_1));
				list6.Add(a4s6);
				dtb.ad().Add(new bm3(150));
				List<auv> list7 = dtb.ad();
				bi5 bi7 = new bi5();
				bi7.a(new int?(1));
				bi7.a(new float?((float)1));
				bi7.a(true);
				a4s a4s7 = new a4s(bi7, null, null, null);
				a4s7.b(new ar7(A_1));
				list7.Add(a4s7);
				dtb.ad().Add(new bm3(200));
				List<auv> list8 = dtb.ad();
				bi5 bi8 = new bi5();
				bi8.a(new int?(1));
				bi8.a(new float?(0f));
				bi8.a(true);
				a4s a4s8 = new a4s(bi8, null, null, null);
				a4s8.b(new ar7(A_1));
				list8.Add(a4s8);
				dtb.ad().Add(new bm3(150));
				aud.Zone.ActionManager.g9(dtb, atp.a);
			}
		}
	}
}
