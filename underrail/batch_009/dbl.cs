using System;
using System.Runtime.Serialization;

// Token: 0x02000A26 RID: 2598
[eiz("XPBLMURE")]
[Serializable]
public sealed class dbl : bdw, ISerializable
{
	// Token: 0x06003DBD RID: 15805 RVA: 0x00172A38 File Offset: 0x00170C38
	private dbl(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003DBE RID: 15806 RVA: 0x00172A40 File Offset: 0x00170C40
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003DBF RID: 15807 RVA: 0x00172A44 File Offset: 0x00170C44
	public dbl()
	{
	}

	// Token: 0x06003DC0 RID: 15808 RVA: 0x00172A50 File Offset: 0x00170C50
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow != null)
			{
				if (!serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_mu_allowedElevator", new bool?(false)).Value)
				{
					serviceOrThrow.aqu().r()["loc_mu_allowedInside"] = false;
					serviceOrThrow.aqu().r()["npc_mu_entrance_met"] = false;
				}
				aud aud = A_0.n("xpbl_b7");
				aud aud2 = A_0.n("xpbl_b7_1");
				if (aud2 != null)
				{
					axh aspect = (new ar7(new Guid("6052a355-eb3b-4b99-9a6d-97407c2e01fa"), aud2).ao() as c5x).GetAspect<axh>();
					if (aspect != null)
					{
						aspect.a("mu_fullPower");
						aspect.a(null, false, null);
						c5x c5x = new ar7(new Guid("429cb58f-fba9-4772-bad2-313a024432e7"), aud2).ao() as c5x;
						c5x c5x2 = new ar7(new Guid("403b81ea-a8ec-46a3-8ef0-86b2b5ddba59"), aud2).ao() as c5x;
						if (c5x != null)
						{
							dt5 aspect2 = c5x.GetAspect<dt5>();
							if (aspect2 != null)
							{
								aspect2.g().Clear();
								aspect2.g().Add("mu_fullPower");
								aspect2.b();
								aspect2.h();
							}
						}
						if (c5x2 != null)
						{
							dt5 aspect3 = c5x2.GetAspect<dt5>();
							if (aspect3 != null)
							{
								aspect3.g().Clear();
								aspect3.g().Add("mu_fullPower");
								aspect3.b();
								aspect3.h();
							}
						}
						c5x c5x3 = new ar7(new Guid("7095f1e6-4a6b-43ea-b7b9-3cd0f12ed8d2"), aud2).ao() as c5x;
						if (c5x3 != null)
						{
							a0l.a(c5x3, "PowerBox", true);
						}
						if (aud != null)
						{
							c5x c5x4 = new ar7(new Guid("4e15a4f8-0d3d-4e54-8863-9aa06f800b3b"), aud).ao() as c5x;
							c5x c5x5 = new ar7(new Guid("eb561593-12a4-42a5-a07d-f1cb80bae04b"), aud).ao() as c5x;
							if (c5x4 != null)
							{
								dt5 aspect4 = c5x4.GetAspect<dt5>();
								if (aspect4 != null)
								{
									aspect4.g().Clear();
									aspect4.g().Add("mu_fullPower");
									aspect4.b();
									aspect4.h();
								}
							}
							if (c5x5 != null)
							{
								dt5 aspect5 = c5x5.GetAspect<dt5>();
								if (aspect5 != null)
								{
									aspect5.g().Clear();
									aspect5.g().Add("mu_fullPower");
									aspect5.b();
									aspect5.h();
								}
							}
						}
					}
				}
			}
		}
	}
}
