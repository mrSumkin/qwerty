using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules;

// Token: 0x020007C0 RID: 1984
[eiz("CCUTEBTJ")]
[Serializable]
public sealed class cay : cze, ISerializable
{
	// Token: 0x060031AE RID: 12718 RVA: 0x0013065C File Offset: 0x0012E85C
	private cay(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("CCUTEBTJ:R");
		this.b = A_0.GetString("CCUTEBTJ:B");
	}

	// Token: 0x060031AF RID: 12719 RVA: 0x00130690 File Offset: 0x0012E890
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCUTEBTJ:R", this.a);
		info.AddValue("CCUTEBTJ:B", this.b);
	}

	// Token: 0x060031B0 RID: 12720 RVA: 0x001306BC File Offset: 0x0012E8BC
	public int a()
	{
		return this.a;
	}

	// Token: 0x060031B1 RID: 12721 RVA: 0x001306C4 File Offset: 0x0012E8C4
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060031B2 RID: 12722 RVA: 0x001306D0 File Offset: 0x0012E8D0
	public string b()
	{
		return this.b;
	}

	// Token: 0x060031B3 RID: 12723 RVA: 0x001306D8 File Offset: 0x0012E8D8
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060031B4 RID: 12724 RVA: 0x001306E4 File Offset: 0x0012E8E4
	public cay()
	{
	}

	// Token: 0x060031B5 RID: 12725 RVA: 0x001306F8 File Offset: 0x0012E8F8
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		if (c5x != null && A_2 != null)
		{
			object obj;
			A_2.TryGetValue("tickCount", out obj);
			if (obj is int)
			{
				this.a--;
				c5x c5x2 = Enumerable.FirstOrDefault<b0b>(c5x.a().ab4(new string[]
				{
					this.b
				})) as c5x;
				if (c5x2 != null)
				{
					bmj.a(c5x2, new efj(this.a));
					if (this.a == 0)
					{
						cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
						if (serviceOrThrow != null)
						{
							switch (serviceOrThrow.aqu().a())
							{
							case GameDifficulty.Easy:
								this.a = cuo.a.Next(13, 19);
								break;
							case GameDifficulty.Normal:
								this.a = cuo.a.Next(12, 16);
								break;
							case GameDifficulty.Hard:
								this.a = cuo.a.Next(10, 14);
								break;
							case GameDifficulty.Dominating:
								this.a = cuo.a.Next(7, 12);
								break;
							}
						}
						c7f c7f = new c7f();
						c7f.a(new Point((int)c5x.Location.X, (int)c5x.Location.Y));
						c7f.a(new Guid?(c5x.qe()));
						c7f.ym(c5x, c5x, null);
					}
				}
			}
		}
	}

	// Token: 0x04001ABB RID: 6843
	private new int a = 10;

	// Token: 0x04001ABC RID: 6844
	private string b;
}
