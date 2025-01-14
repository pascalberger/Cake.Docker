﻿using System;
using Cake.Core;
using Cake.Core.Annotations;

namespace Cake.Docker
{
    // Contains functionality for working with docker buildx stop command.
    partial class DockerAliases
    {
        /// <summary>
        /// Stop builder instance using default settings.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="name">The name.</param>
        [CakeMethodAlias]
        public static void DockerBuildXStop(this ICakeContext context, string name = null)
        {
            context.DockerBuildXStop(name);
        }
        /// <summary>
        /// Stop builder instance given <paramref name="settings"/>.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="settings">The settings.</param>
        /// <param name="name">The name.</param>
        [CakeMethodAlias]
        public static void DockerBuildXStop(this ICakeContext context, DockerBuildXStopSettings settings = null, string name = null)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            var runner = new GenericDockerRunner<DockerBuildXStopSettings>(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
            runner.Run("buildx stop", new DockerBuildXStopSettings(), new string[] { name });
        }
    }
}
