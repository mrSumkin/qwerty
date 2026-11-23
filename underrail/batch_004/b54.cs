using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020008F0 RID: 2288
[eiz("TCHMU1MLICFP")]
[Serializable]
public sealed class b54 : bdw, ISerializable
{
	// Token: 0x060038AD RID: 14509 RVA: 0x0014FE30 File Offset: 0x0014E030
	private b54(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060038AE RID: 14510 RVA: 0x0014FE38 File Offset: 0x0014E038
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x060038AF RID: 14511 RVA: 0x0014FE3C File Offset: 0x0014E03C
	public b54()
	{
	}

	// Token: 0x060038B0 RID: 14512 RVA: 0x0014FE48 File Offset: 0x0014E048
	public void av(c1a A_0, cyt A_1)
	{
		aud aud = A_0.n("tch_mu1");
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (aud != null && serviceOrThrow != null)
		{
			c5x c5x = new ar7(new Guid("c489e655-66bd-4789-bad7-e8dacaca2b88"), aud).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("6fa6896d-0af2-4868-9db3-cdff7429220c"), aud).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("422b1024-c1d3-48c9-84d6-37aa77361208"), aud).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("22b6c9c4-b62b-497a-9de0-e9444a754157"), aud).ao() as c5x;
			c5x c5x5 = new ar7(new Guid("0b6b3d9b-d255-4f5f-bf0e-fa7ba2f8cde3"), aud).ao() as c5x;
			c5x c5x6 = new ar7(new Guid("008d8b64-89a3-4edc-9a01-139307dcda9a"), aud).ao() as c5x;
			c5x c5x7 = new ar7(new Guid("3f3fc964-f91a-4d7c-9a25-d2ce3db36553"), aud).ao() as c5x;
			c5x c5x8 = new ar7(new Guid("c14e426e-4cd1-4ea0-a006-6592e8d6f7c3"), aud).ao() as c5x;
			c5x c5x9 = new ar7(new Guid("0cc28443-bc28-4f9b-b3dc-0e15b6c0f04c"), aud).ao() as c5x;
			if (c5x != null)
			{
				a0l.a(c5x, "move_lunatic1", true);
				bm6 aspect = c5x.GetAspect<bm6>();
				if (aspect != null)
				{
					aspect.y6()[ddq.ay] = new bt4("move_lunatic1");
				}
			}
			if (c5x2 != null)
			{
				a0l.a(c5x2, "move_lunatic2", true);
				bm6 aspect2 = c5x2.GetAspect<bm6>();
				if (aspect2 != null)
				{
					aspect2.y6()[ddq.ay] = new bt4("move_lunatic2");
				}
			}
			if (c5x3 != null)
			{
				a0l.a(c5x3, "move_lunatic3", true);
				bm6 aspect3 = c5x3.GetAspect<bm6>();
				if (aspect3 != null)
				{
					aspect3.y6()[ddq.ay] = new bt4("move_lunatic3");
				}
			}
			if (c5x4 != null)
			{
				a0l.a(c5x4, "move_lunatic4", true);
				bm6 aspect4 = c5x4.GetAspect<bm6>();
				if (aspect4 != null)
				{
					aspect4.y6()[ddq.ay] = new bt4("move_lunatic4");
				}
			}
			if (c5x5 != null)
			{
				a0l.a(c5x5, "move_lunatic5", true);
				bm6 aspect5 = c5x5.GetAspect<bm6>();
				if (aspect5 != null)
				{
					aspect5.y6()[ddq.ay] = new bt4("move_lunatic5");
				}
			}
			if (c5x6 != null)
			{
				a0l.a(c5x6, "move_lunatic6", true);
				bm6 aspect6 = c5x6.GetAspect<bm6>();
				if (aspect6 != null)
				{
					aspect6.y6()[ddq.ay] = new bt4("move_lunatic6");
				}
			}
			if (c5x7 != null)
			{
				a0l.a(c5x7, "move_lunatic7", true);
				bm6 aspect7 = c5x7.GetAspect<bm6>();
				if (aspect7 != null)
				{
					aspect7.y6()[ddq.ay] = new bt4("move_lunatic7");
				}
			}
			if (c5x8 != null)
			{
				a0l.a(c5x8, "move_lunatic8", true);
				bm6 aspect8 = c5x8.GetAspect<bm6>();
				if (aspect8 != null)
				{
					aspect8.y6()[ddq.ay] = new bt4("move_lunatic8");
				}
			}
			if (c5x9 != null)
			{
				c5x9.Location = new Vector3(22f, 39f, 0f);
				c5x9.ah();
			}
		}
	}
}
