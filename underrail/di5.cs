using System;
using System.Runtime.Serialization;

// Token: 0x02000931 RID: 2353
[eiz("CCDBP")]
[Serializable]
public sealed class di5 : bdw, ISerializable
{
	// Token: 0x060039B8 RID: 14776 RVA: 0x00155724 File Offset: 0x00153924
	private di5(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060039B9 RID: 14777 RVA: 0x0015572C File Offset: 0x0015392C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060039BA RID: 14778 RVA: 0x00155730 File Offset: 0x00153930
	public di5()
	{
	}

	// Token: 0x060039BB RID: 14779 RVA: 0x0015573C File Offset: 0x0015393C
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("lu-c5");
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("2cdad8ad-434f-41ae-9d33-ab892cf25a72"), aud).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("4ad99a86-9c14-409c-b712-dfd5e15f9633"), aud).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("d89ad461-9fe4-4c4b-95e8-f0aac43a54cd"), aud).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("cdb44d0b-1fff-4d39-9aab-9aea624892bf"), aud).ao() as c5x;
			c5x c5x5 = new ar7(new Guid("9ab914bb-6dae-4298-9af8-65e5635d64f0"), aud).ao() as c5x;
			c5x c5x6 = new ar7(new Guid("f930e0a1-cb37-4813-a54e-e2bc102fc45d"), aud).ao() as c5x;
			if (c5x != null)
			{
				c5x.w();
				c5x.an();
			}
			if (c5x2 != null)
			{
				c5x2.w();
				c5x2.an();
			}
			if (c5x3 != null)
			{
				c5x3.w();
				c5x3.an();
			}
			if (c5x4 != null)
			{
				c5x4.w();
				c5x4.an();
			}
			if (c5x5 != null)
			{
				bn5 bn = c5x5.GetAspect<j7>() as bn5;
				if (bn != null)
				{
					bn.b("support\\cc_praetorianGuard");
				}
			}
			if (c5x6 != null)
			{
				bn5 bn2 = c5x6.GetAspect<j7>() as bn5;
				if (bn2 != null)
				{
					bn2.b("support\\cc_praetorianGuard");
				}
				bm6 aspect = c5x6.GetAspect<bm6>();
				if (aspect != null)
				{
					aspect.y6()[ddq.ay] = new bt4("MoveGuard");
					a0l.a(c5x6, "MoveGuard", true);
				}
			}
			c5x c5x7 = new ar7(new Guid("013c8aa7-dc6b-47fb-bfbd-894f1a3283a6"), aud).ao() as c5x;
			if (c5x7 != null)
			{
				c5x7.w();
				c5x7.an();
			}
			d60 d = A_0.a();
			if (d != null)
			{
				foreach (b0b b0b in d.ab4(new string[]
				{
					"despawn_blockade"
				}))
				{
					b0b.w();
					b0b.an();
				}
			}
		}
	}
}
