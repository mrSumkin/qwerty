using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x02000AC7 RID: 2759
[eiz("XPHWEBVPFDJ")]
[Serializable]
public sealed class cev : cze, ISerializable
{
	// Token: 0x0600404F RID: 16463 RVA: 0x00187274 File Offset: 0x00185474
	private cev(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (HorizontalDirection?)A_0.GetValue("XPHWEBVPFDJ:D", typeof(HorizontalDirection?));
		this.b = A_0.GetBoolean("XPHWEBVPFDJ:A");
	}

	// Token: 0x06004050 RID: 16464 RVA: 0x001872B0 File Offset: 0x001854B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPHWEBVPFDJ:D", this.a);
		info.AddValue("XPHWEBVPFDJ:A", this.b);
	}

	// Token: 0x06004051 RID: 16465 RVA: 0x001872E4 File Offset: 0x001854E4
	public HorizontalDirection? b()
	{
		return this.a;
	}

	// Token: 0x06004052 RID: 16466 RVA: 0x001872EC File Offset: 0x001854EC
	public void a(HorizontalDirection? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004053 RID: 16467 RVA: 0x001872F8 File Offset: 0x001854F8
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06004054 RID: 16468 RVA: 0x00187300 File Offset: 0x00185500
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06004055 RID: 16469 RVA: 0x0018730C File Offset: 0x0018550C
	public cev()
	{
	}

	// Token: 0x06004056 RID: 16470 RVA: 0x00187318 File Offset: 0x00185518
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				c5x c5x2 = new ar7(new Guid("114ee4b2-9d26-4a2d-b2e5-e547ebced2d7"), c5x.Area).ao() as c5x;
				if (c5x2 != null)
				{
					string text = "";
					HorizontalDirection? horizontalDirection = this.a;
					if (horizontalDirection != null)
					{
						switch (horizontalDirection.GetValueOrDefault())
						{
						case HorizontalDirection.North:
							text = "northShouldAttack";
							break;
						case HorizontalDirection.East:
							text = "eastShouldAttack";
							break;
						case HorizontalDirection.South:
							text = "southShouldAttack";
							break;
						case HorizontalDirection.West:
							text = "westShouldAttack";
							break;
						}
					}
					if (!text.Equals(""))
					{
						if (this.a())
						{
							c5x2.b(text);
							return;
						}
						e3l aspect = c5x2.GetAspect<e3l>();
						if (aspect != null)
						{
							aspect.a.Remove(text);
							aspect.a();
						}
					}
				}
			}
		}
	}

	// Token: 0x04001BF2 RID: 7154
	private new HorizontalDirection? a;

	// Token: 0x04001BF3 RID: 7155
	private bool b;
}
