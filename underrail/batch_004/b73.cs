using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x02000FC7 RID: 4039
[eiz("GDC")]
[Serializable]
public sealed class b73 : dnh, ISerializable
{
	// Token: 0x06005300 RID: 21248 RVA: 0x0024F73C File Offset: 0x0024D93C
	private b73(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("GDC:MID", typeof(GameDifficulty?)) as GameDifficulty?);
		this.b = (A_0.GetValue("GDC:MAD", typeof(GameDifficulty?)) as GameDifficulty?);
		if (ell.a() >= 708)
		{
			this.c = (GameDifficultyType)A_0.GetInt32("GDC:DT");
		}
	}

	// Token: 0x06005301 RID: 21249 RVA: 0x0024F7BC File Offset: 0x0024D9BC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GDC:MID", this.a);
		info.AddValue("GDC:MAD", this.b);
		info.AddValue("GDC:DT", (int)this.c);
	}

	// Token: 0x06005302 RID: 21250 RVA: 0x0024F810 File Offset: 0x0024DA10
	public GameDifficulty? c()
	{
		return this.a;
	}

	// Token: 0x06005303 RID: 21251 RVA: 0x0024F818 File Offset: 0x0024DA18
	public void b(GameDifficulty? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005304 RID: 21252 RVA: 0x0024F824 File Offset: 0x0024DA24
	public GameDifficulty? a()
	{
		return this.b;
	}

	// Token: 0x06005305 RID: 21253 RVA: 0x0024F82C File Offset: 0x0024DA2C
	public void a(GameDifficulty? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005306 RID: 21254 RVA: 0x0024F838 File Offset: 0x0024DA38
	public GameDifficultyType b()
	{
		return this.c;
	}

	// Token: 0x06005307 RID: 21255 RVA: 0x0024F840 File Offset: 0x0024DA40
	public void a(GameDifficultyType A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005308 RID: 21256 RVA: 0x0024F84C File Offset: 0x0024DA4C
	public b73()
	{
	}

	// Token: 0x06005309 RID: 21257 RVA: 0x0024F858 File Offset: 0x0024DA58
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (bpo.GetService<bu6>() != null)
		{
			GameDifficulty gameDifficulty;
			if (this.c == GameDifficultyType.Puzzle)
			{
				gameDifficulty = euf.b().PuzzleDifficulty;
			}
			else
			{
				gameDifficulty = euf.b().EncounterDifficulty;
			}
			if (this.a != null && gameDifficulty < this.a.Value)
			{
				return false;
			}
			if (this.b != null && gameDifficulty > this.b.Value)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x040021F2 RID: 8690
	private GameDifficulty? a;

	// Token: 0x040021F3 RID: 8691
	private GameDifficulty? b;

	// Token: 0x040021F4 RID: 8692
	private GameDifficultyType c;
}
