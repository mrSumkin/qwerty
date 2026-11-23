using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020009A3 RID: 2467
[eiz("LUSRFF")]
[Serializable]
public sealed class eew : bdw, ISerializable
{
	// Token: 0x06003B88 RID: 15240 RVA: 0x00160550 File Offset: 0x0015E750
	private eew(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003B89 RID: 15241 RVA: 0x00160558 File Offset: 0x0015E758
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003B8A RID: 15242 RVA: 0x0016055C File Offset: 0x0015E75C
	public eew()
	{
	}

	// Token: 0x06003B8B RID: 15243 RVA: 0x00160568 File Offset: 0x0015E768
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("lu-b31");
			if (aud != null)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("quest_fd_AttackSROSpyRevealed", new bool?(false)).Value)
				{
					doq a_ = doq.a(Path.Combine(d5x.q(), "lu-b31_l2") + ".uzl");
					aud.Zone.a(a_, 1, null);
					c5x c5x = new ar7(new Guid("f96447bb-0d8b-46b6-9496-68fd253d2fe9"), aud).ao() as c5x;
					c5x c5x2 = new ar7(new Guid("243dfee7-3933-48f7-81e1-f03f333924d7"), aud).ao() as c5x;
					c5x c5x3 = new ar7(new Guid("d68568a5-22ad-426b-bf82-0642aeb199cf"), aud).ao() as c5x;
					c5x c5x4 = new ar7(new Guid("c3f2456f-83fd-4c35-a7e1-b96c5d2acbc9"), aud).ao() as c5x;
					c5x c5x5 = new ar7(new Guid("874a34d8-7eb1-40db-8bc8-198e8547c806"), aud).ao() as c5x;
					c5x c5x6 = new ar7(new Guid("d71e3778-84da-4344-b8e3-07f2c1cebba7"), aud).ao() as c5x;
					c5x c5x7 = new ar7(new Guid("1ffa01e4-b6ed-402f-b3ce-cf2c4218a801"), aud).ao() as c5x;
					c5x c5x8 = new ar7(new Guid("01816ec2-5e15-4dcb-865f-f65da63e9c22"), aud).ao() as c5x;
					c5x c5x9 = new ar7(new Guid("82624722-f0c3-4d75-83d1-6609e710dfc3"), aud).ao() as c5x;
					c5x c5x10 = new ar7(new Guid("4199b6e3-b74b-411d-a46c-7b1bdbcbdbfe"), aud).ao() as c5x;
					if (c5x != null)
					{
						a0l.a(c5x, "guard_cliftonDefense", true);
						c5x.t.b.y6()[ddq.ay] = new bt4("guard_cliftonDefense");
					}
					if (c5x2 != null)
					{
						a0l.a(c5x2, "moved_guard1", true);
						c5x2.t.b.y6()[ddq.ay] = new bt4("moved_guard1");
					}
					if (c5x3 != null)
					{
						a0l.a(c5x3, "moved_guard2", true);
						c5x3.t.b.y6()[ddq.ay] = new bt4("moved_guard2");
					}
					if (c5x4 != null)
					{
						a0l.a(c5x4, "moved_guard3", true);
						c5x4.t.b.y6()[ddq.ay] = new bt4("moved_guard3");
					}
					if (c5x5 != null)
					{
						a0l.a(c5x5, "moved_guard4", true);
						c5x5.t.b.y6()[ddq.ay] = new bt4("moved_guard4");
					}
					if (c5x6 != null)
					{
						a0l.a(c5x6, "moved_guard5", true);
						c5x6.t.b.y6().RemoveProperty(ddq.k);
						c5x6.t.b.y6()[ddq.ay] = new bt4("moved_guard5");
					}
					if (c5x7 != null)
					{
						a0l.a(c5x7, "moved_guard6", true);
						c5x7.t.b.y6().RemoveProperty(ddq.k);
						c5x7.t.b.y6()[ddq.ay] = new bt4("moved_guard6");
					}
					if (c5x9 != null)
					{
						c5x9.an();
						c5x9.w();
					}
					if (c5x10 != null)
					{
						c5x10.an();
						c5x10.w();
					}
					if (c5x8 != null)
					{
						bja aspect = c5x8.GetAspect<bja>();
						if (aspect != null)
						{
							aspect.a("");
						}
					}
				}
			}
		}
	}
}
