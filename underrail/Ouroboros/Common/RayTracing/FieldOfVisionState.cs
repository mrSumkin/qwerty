using System;

namespace Ouroboros.Common.RayTracing
{
	// Token: 0x02000037 RID: 55
	[eiz("eFOVS")]
	[Serializable]
	public enum FieldOfVisionState
	{
		// Token: 0x040001C9 RID: 457
		Created,
		// Token: 0x040001CA RID: 458
		MarkedForUpdate,
		// Token: 0x040001CB RID: 459
		Updating,
		// Token: 0x040001CC RID: 460
		Updated,
		// Token: 0x040001CD RID: 461
		Destroying,
		// Token: 0x040001CE RID: 462
		Destroyed,
		// Token: 0x040001CF RID: 463
		Interupted
	}
}
