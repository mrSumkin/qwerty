using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020009C9 RID: 2505
[eiz("FBI1")]
[Serializable]
public sealed class agg : bdw, ISerializable
{
	// Token: 0x06003C1F RID: 15391 RVA: 0x00163584 File Offset: 0x00161784
	private agg(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C20 RID: 15392 RVA: 0x0016358C File Offset: 0x0016178C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C21 RID: 15393 RVA: 0x00163590 File Offset: 0x00161790
	public agg()
	{
	}

	// Token: 0x06003C22 RID: 15394 RVA: 0x0016359C File Offset: 0x0016179C
	public void av(c1a A_0, cyt A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && A_0 != null)
		{
			aud aud = A_0.n("fo-bunker");
			if (aud != null)
			{
				csd csd = A_0.g("guard_guard1");
				csd csd2 = A_0.g("guard_guard2");
				csd csd3 = A_0.g("guard_investigator");
				csd csd4 = A_0.g("guard_coroner");
				c5x c5x = new ar7(new Guid("0c1a08b2-d329-4cc4-9ec0-fcc48d43c49f"), aud).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("3092ba05-2fba-4eea-9502-589828e5ea91"), aud).ao() as c5x;
				Point b = new Point(5, 0);
				if (csd != null)
				{
					vq.a("creature\\characters\\support\\fo_bunkerGuard1", csd, true);
				}
				if (csd2 != null)
				{
					vq.a("creature\\characters\\support\\fo_bunkerGuard2", csd2, true);
				}
				if (csd3 != null)
				{
					vq.a("creature\\characters\\support\\fo_bunkerInvestigator", csd3, true);
				}
				if (csd4 != null)
				{
					vq.a("creature\\characters\\support\\fo_bunkerCoroner", csd4, true);
				}
				if (c5x != null)
				{
					cd0 aspect = c5x.GetAspect<cd0>();
					c5x.TileFormationModifiers.c();
					c5x.z();
					c5x.VisualPriority = -1;
					if (aspect != null)
					{
						aspect.b = b;
					}
				}
				if (c5x2 != null)
				{
					cd0 aspect2 = c5x2.GetAspect<cd0>();
					c5x2.TileFormationModifiers.c();
					c5x2.z();
					c5x2.VisualPriority = 1;
					if (aspect2 != null)
					{
						aspect2.b = b;
					}
				}
			}
		}
	}
}
