using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000A9B RID: 2715
[eiz("LUULPJ")]
[Serializable]
public sealed class ch5 : cze, ISerializable
{
	// Token: 0x06003F9A RID: 16282 RVA: 0x00182434 File Offset: 0x00180634
	private ch5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06003F9B RID: 16283 RVA: 0x00182440 File Offset: 0x00180640
	public ch5()
	{
	}

	// Token: 0x06003F9C RID: 16284 RVA: 0x0018244C File Offset: 0x0018064C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null && serviceOrThrow.aqw().y8() == "lup-a8Prison")
		{
			aud aud = serviceOrThrow.aqw().n("lup-a8Prison");
			if (aud != null)
			{
				for (int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 3; j++)
					{
						int num = 6 + i * 3;
						int num2 = 12 + j * 3;
						d2b d2b = null;
						List<c5x> list = new List<c5x>();
						for (int k = num; k <= num + 3; k++)
						{
							for (int l = num2; l <= num2 + 3; l++)
							{
								ak1 ak = aud.b(k, l);
								if (ak != null)
								{
									foreach (b0b b0b in ak.c.Values)
									{
										c5x c5x = (c5x)b0b;
										if (!c5x.IsFloor && !c5x.IsGround && c5x.Layer == aju.x)
										{
											if (d2b == null && c5x.y8() == "Door")
											{
												d2b aspect = c5x.GetAspect<d2b>();
												if (aspect != null)
												{
													d2b = aspect;
												}
											}
											if (c5x.h.b != null && (c5x.h.b.aa().FactionId == asp.b7 || c5x.h.b.aa().FactionId == asp.b8))
											{
												list.Add(c5x);
											}
										}
									}
								}
							}
						}
						if (d2b != null && list.Count > 0)
						{
							foreach (c5x c5x2 in list)
							{
								if (c5x2.t.b != null && !d2b.n())
								{
									c5x2.t.b.y6()[ddq.ay] = new bt4("FromLadder");
								}
							}
						}
					}
				}
			}
		}
	}
}
