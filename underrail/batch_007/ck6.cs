using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x020010DC RID: 4316
[eiz("SGCOR")]
[Serializable]
public sealed class ck6 : cze, ISerializable
{
	// Token: 0x06005AFE RID: 23294 RVA: 0x00272A38 File Offset: 0x00270C38
	private ck6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Color)A_0.GetValue("SGCOR:V", typeof(Color));
		di7.ReadList<string>("SGCOR:E", ref this.b, A_0);
		if (ell.a() >= 528)
		{
			this.c = A_0.GetString("SGCOR:R");
		}
	}

	// Token: 0x06005AFF RID: 23295 RVA: 0x00272AAC File Offset: 0x00270CAC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGCOR:V", this.a);
		di7.WriteList<string>("SGCOR:E", this.b, info);
		info.AddValue("SGCOR:R", this.c);
	}

	// Token: 0x06005B00 RID: 23296 RVA: 0x00272AFC File Offset: 0x00270CFC
	public Color c()
	{
		return this.a;
	}

	// Token: 0x06005B01 RID: 23297 RVA: 0x00272B04 File Offset: 0x00270D04
	public void a(Color A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005B02 RID: 23298 RVA: 0x00272B10 File Offset: 0x00270D10
	public List<string> a()
	{
		return this.b;
	}

	// Token: 0x06005B03 RID: 23299 RVA: 0x00272B18 File Offset: 0x00270D18
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005B04 RID: 23300 RVA: 0x00272B24 File Offset: 0x00270D24
	public string b()
	{
		return this.c;
	}

	// Token: 0x06005B05 RID: 23301 RVA: 0x00272B2C File Offset: 0x00270D2C
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005B06 RID: 23302 RVA: 0x00272B38 File Offset: 0x00270D38
	public ck6()
	{
	}

	// Token: 0x06005B07 RID: 23303 RVA: 0x00272B4C File Offset: 0x00270D4C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null && A_0.Area != null && A_0.Area.Zone != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null && A_1.Area != null && A_1.Area.Zone != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			List<c5x> list = new List<c5x>();
			if (this.b.Count > 0)
			{
				foreach (string g in this.b)
				{
					c5x c5x = new ar7(new Guid(g), aud).ao() as c5x;
					if (c5x != null)
					{
						list.Add(c5x);
					}
				}
			}
			if (!string.IsNullOrWhiteSpace(this.c) && aud.Zone != null)
			{
				d60 d = aud.Zone.a();
				if (d != null)
				{
					List<b0b> list2 = d.ab4(new string[]
					{
						this.c
					});
					list.AddRange(Enumerable.OfType<c5x>(list2));
				}
			}
			foreach (c5x c5x2 in list)
			{
				if (c5x2 != null && c5x2.o.b != null)
				{
					c5x2.ad = new Color?(this.a);
				}
			}
		}
	}

	// Token: 0x04002461 RID: 9313
	private new Color a;

	// Token: 0x04002462 RID: 9314
	private List<string> b = new List<string>();

	// Token: 0x04002463 RID: 9315
	private string c;
}
