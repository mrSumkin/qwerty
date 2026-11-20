using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Ouroboros.Playfield.Space;

// Token: 0x02001039 RID: 4153
[eiz("CJCJ")]
[Serializable]
public sealed class cr5 : cze
{
	// Token: 0x060055CB RID: 21963 RVA: 0x0025CDC0 File Offset: 0x0025AFC0
	private cr5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		di7.ReadList<HorizontalDirection>("CJCJ:D", ref this.a, A_0);
		this.b = (A_0.GetValue("CJCJ:C", typeof(dth)) as dth);
		this.c = (A_0.GetValue("CJCJ:J", typeof(cze)) as cze);
	}

	// Token: 0x060055CC RID: 21964 RVA: 0x0025CE34 File Offset: 0x0025B034
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<HorizontalDirection>("CJCJ:D", this.a, info);
		info.AddValue("CJCJ:C", this.b);
		info.AddValue("CJCJ:J", this.c);
	}

	// Token: 0x060055CD RID: 21965 RVA: 0x0025CE74 File Offset: 0x0025B074
	public List<HorizontalDirection> b()
	{
		return this.a;
	}

	// Token: 0x060055CE RID: 21966 RVA: 0x0025CE7C File Offset: 0x0025B07C
	public void a(List<HorizontalDirection> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060055CF RID: 21967 RVA: 0x0025CE88 File Offset: 0x0025B088
	public dth c()
	{
		return this.b;
	}

	// Token: 0x060055D0 RID: 21968 RVA: 0x0025CE90 File Offset: 0x0025B090
	public void a(dth A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060055D1 RID: 21969 RVA: 0x0025CE9C File Offset: 0x0025B09C
	public cze a()
	{
		return this.c;
	}

	// Token: 0x060055D2 RID: 21970 RVA: 0x0025CEA4 File Offset: 0x0025B0A4
	public void a(cze A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060055D3 RID: 21971 RVA: 0x0025CEB0 File Offset: 0x0025B0B0
	public cr5()
	{
	}

	// Token: 0x060055D4 RID: 21972 RVA: 0x0025CEC4 File Offset: 0x0025B0C4
	public override string ToString()
	{
		string text;
		if (this.c != null)
		{
			text = this.c.ToString();
		}
		else
		{
			text = "Безработный";
		}
		if (this.b != null)
		{
			string text2 = this.b.ji();
			if (string.IsNullOrEmpty(text2))
			{
				text2 = this.b.GetType().Name;
			}
			text = string.Concat(new string[]
			{
				"{",
				text2,
				" ? ",
				text,
				"}"
			});
		}
		else if (this.a != null && this.a.Count > 0)
		{
			string text3 = "";
			for (int i = 0; i < this.a.Count; i++)
			{
				HorizontalDirection a_ = this.a[i];
				if (i != 0)
				{
					text3 += " | ";
				}
				text3 += bnx.a(a_);
			}
			text = string.Concat(new string[]
			{
				"[",
				text3,
				" - ",
				text,
				"]"
			});
		}
		return text;
	}

	// Token: 0x060055D5 RID: 21973 RVA: 0x0025CFF0 File Offset: 0x0025B1F0
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.c != null)
		{
			if (this.a != null && this.a.Count > 0)
			{
				HorizontalDirection? horizontalDirection = null;
				object obj;
				if (A_2 != null && A_2.TryGetValue("usageDirection", out obj) && obj is HorizontalDirection)
				{
					horizontalDirection = new HorizontalDirection?((HorizontalDirection)obj);
				}
				if (horizontalDirection != null && !this.a.Contains(horizontalDirection.Value))
				{
					return;
				}
			}
			if (this.b != null && !this.c().jh(new e2f(A_0, A_1, A_2)))
			{
				return;
			}
			this.c.ym(A_0, A_1, A_2);
		}
	}

	// Token: 0x040022E0 RID: 8928
	private new List<HorizontalDirection> a = new List<HorizontalDirection>();

	// Token: 0x040022E1 RID: 8929
	private dth b;

	// Token: 0x040022E2 RID: 8930
	private cze c;
}
